using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Master
{
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    using PasswordManager.Master.Listup;
    using PasswordManager.Model;

    public partial class MainConfig : IMainConfig
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static readonly Color DEFAULT_HIDE_FORE = Color.FromArgb(255, 32, 0, 0);
        public static readonly Color DEFAULT_HIDE_BACK = Color.FromArgb(255, 16, 0, 0);
        public static readonly Color DEFAULT_SHOW_FORE = Color.Black;
        public static readonly Color DEFAULT_SHOW_BACK = Color.White;

        public event Action PasswordConfirmed = new Action(() => { });
        public event Action ItemModified = new Action(() => { });

        private string name;
        private string confFolderPath;

        private string password;
        private byte[] hashedPass;
        private byte[] hashSalt;

        private readonly BindingSource items = new BindingSource();

        public string ConfName {
            get { return name; }
            set
            {
                if (!string.Equals(name, value))
                {
                    name = value;
                    PropertyChangedEvent("ConfName");
                }
            }
        }
        private Color hideFore;
        private Color hideBack;
        private Color showFore;
        private Color showBack;
        public Color HideFore
        {
            set
            {
                if (!Color.Equals(hideFore, value))
                {
                    hideFore = value;
                    PropertyChangedEvent("HideFore");
                }

            }
            get { return hideFore; }
        }
        public Color HideBack
        {
            set
            {
                if (!Color.Equals(hideBack, value))
                {
                    hideBack = value;
                    PropertyChangedEvent("HideBack");
                }
            }
            get { return hideBack; }
        }
        public Color ShowFore
        {
            set
            {
                if (!Color.Equals(showFore, value))
                {
                    showFore = value;
                    PropertyChangedEvent("ShowFore");
                }
            }
            get { return showFore; }
        }
        public Color ShowBack
        {
            set
            {
                if (!Color.Equals(showBack, value))
                {
                    showBack = value;
                    PropertyChangedEvent("ShowBack");
                }
            }
            get { return showBack; }
        }

        private string datFolderPrevious;
        private string datFolder;
        public string DatFolder
        {
            set
            {
                if (!string.Equals(datFolder, value))
                {
                    datFolder = value;
                    PropertyChangedEvent("DatFolder");
                }
            }
            get { return datFolder; }
        }
        private string remarks;
        public string Remarks
        {
            set
            {
                if (!string.Equals(remarks, value))
                {
                    remarks = value;
                    PropertyChangedEvent("Remarks");
                }
            }
            get { return remarks; }
        }
        public BindingSource Items { get { return items; } }

        public byte[] HashedPass
        {
            set
            {
                hashedPass = value;
                password = null;
                IsPasswordConfirmed = false;
            }
            get { return hashedPass; }
        }
        public string Password
        {
            set
            {
                password = value;
                hashedPass = PasswordFactory.ToHash(value, this);
                IsPasswordConfirmed = true;

                PasswordConfirmed();
            }
            get
            {
                return password;
            }
        }
        public byte[] GetSalt()
        {
            if (hashSalt == null)
            {
                hashSalt = PasswordFactory.CreateNewSalt();
            }
            return hashSalt;
        }
        public bool IsPasswordConfirmed { private set; get; }

        public void SaveToFile()
        {
            using (var os = File.OpenWrite(this.confFolderPath + "\\" + this.name + ".ytel"))
            {
                FileIo.WriteUtf8Bytes(os, DatFolder);
                FileIo.WriteUtf8Bytes(os, Remarks);
                os.Write(HashedPass, 0, HashedPass.Length);
                os.Write(hashSalt, 0, hashSalt.Length);
                FileIo.WriteColor(os, HideFore);
                FileIo.WriteColor(os, HideBack);
                FileIo.WriteColor(os, ShowFore);
                FileIo.WriteColor(os, ShowBack);
            }
            if (! string.Equals(datFolderPrevious, DatFolder))
            {
                Directory.Move(datFolderPrevious, DatFolder);
            }
        }

        public void ReadFromFile(string path)
        {
            FileInfo file = new FileInfo(path);
            string fileName = file.Name;
            string extention = file.Extension;
            string name = fileName.Substring(0, fileName.Length - extention.Length);
            string confFolderPath = file.DirectoryName;
            using (var input = file.OpenRead())
            {
                string DatFolder = FileIo.ReadString(input);
                string Remarks = FileIo.ReadString(input); ;
                byte[] hashedPass = new byte[64];
                input.Read(hashedPass, 0, 64);
                byte[] hashSalt = new byte[8];
                input.Read(hashSalt, 0, 8);

                Color hideFore = FileIo.ReadColor(input);
                Color hideBack = FileIo.ReadColor(input);
                Color showFore = FileIo.ReadColor(input);
                Color showBack = FileIo.ReadColor(input);

                this.DatFolder = DatFolder;
                this.datFolderPrevious = DatFolder;
                this.name = name;
                this.confFolderPath = confFolderPath;
                this.HashedPass = hashedPass;
                this.hashSalt = hashSalt;
                this.HideFore = hideFore;
                this.HideBack = hideBack;
                this.ShowFore = showFore;
                this.ShowBack = showBack;
                this.Remarks = Remarks;
            }
            ReadItems();
        }
        private void ReadItems()
        {
            DirectoryInfo dir = new DirectoryInfo(DatFolder);
            var childs = dir.GetDirectories();
            foreach (var child in childs)
            {
                var newItem = ItemPolicy.LoadFromFile(child.FullName + "\\policy");
                items.Add(newItem);
            }
        }

        internal void CreateNewConf(string name, string confFolderPath, string password, string dataFolderPath)
        {
            this.name = name;
            this.confFolderPath = confFolderPath;
            this.Password = password;
            this.DatFolder = dataFolderPath;
            this.datFolderPrevious = dataFolderPath;

            this.HideFore = DEFAULT_HIDE_FORE;
            this.HideBack = DEFAULT_HIDE_BACK;
            this.ShowFore = DEFAULT_SHOW_FORE;
            this.ShowBack = DEFAULT_SHOW_BACK;

            this.remarks = string.Empty;
            this.SaveToFile();

            if (!Directory.Exists(DatFolder))
            {
                Directory.CreateDirectory(DatFolder);
            }
        }
        public void AddItem(ItemPolicy policy)
        {
            items.Add(policy);
            ItemModified();
        }
        public IEnumerator<ItemPolicy> GetItems()
        {
            foreach (var item in items)
            {
                yield return (ItemPolicy)item;
            }
        }

        private void PropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
