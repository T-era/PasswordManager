using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Master
{
    using System.Drawing;
    using System.IO;
    using PasswordManager.Model;

    public partial class MainConfig : IMainConfig
    {
        public static readonly Color DEFAULT_HIDE_FORE = Color.FromArgb(255, 32, 0, 0);
        public static readonly Color DEFAULT_HIDE_BACK = Color.FromArgb(255, 16, 0, 0);
        public static readonly Color DEFAULT_SHOW_FORE = Color.Black;
        public static readonly Color DEFAULT_SHOW_BACK = Color.White;

        public event Action PasswordConfirmed = new Action(() => { });

        private string name;
        private string confFolderPath;

        private string password;
        private byte[] hashedPass;

        public string ConfName { get { return name; } }
        public Color HideFore { set; get; }
        public Color HideBack { set; get; }
        public Color ShowFore { set; get; }
        public Color ShowBack { set; get; }
        public string DatFolder { set; get; }
        public string Remarks { set; get; }

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
                hashedPass = PasswordFactory.ToHash(value);
                IsPasswordConfirmed = true;

                PasswordConfirmed();
            }
            get
            {
                return password;
            }
        }
        public bool IsPasswordConfirmed { private set; get; }

        public void SaveToFile()
        {
            using (var os = File.OpenWrite(this.confFolderPath + "\\" + this.name + ".ytel"))
            {
                WriteUtf8Bytes(os, DatFolder);
                os.WriteByte(0);
                WriteUtf8Bytes(os, Remarks);
                os.WriteByte(0);
                os.Write(HashedPass, 0, HashedPass.Length);
                WriteColor(os, HideFore);
                WriteColor(os, HideBack);
                WriteColor(os, ShowFore);
                WriteColor(os, ShowBack);
            }
        }
        private static void WriteUtf8Bytes(FileStream stream, string str)
        {
            var bytes = UTF8Encoding.UTF8.GetBytes(str);
            stream.Write(bytes, 0, bytes.Length);
        }
        private static void WriteColor(FileStream stream, Color color)
        {
            stream.WriteByte(color.A);
            stream.WriteByte(color.R);
            stream.WriteByte(color.G);
            stream.WriteByte(color.B);
        }

        public void ReadFromFile(string path)
        {
            FileInfo file = new FileInfo(path);
            string fileName = file.Name;
            string extention = file.Extension;
            string name = fileName.Remove(extention.Length - 1);
            string confFolderPath = file.DirectoryName;
            using (var input = file.OpenRead())
            {
                string DatFolder = ReadString(input);
                string Remarks = ReadString(input); ;
                byte[] hashedPass = new byte[64];
                input.Read(hashedPass, 0, 64);

                Color hideFore = ReadColor(input);
                Color hideBack = ReadColor(input);
                Color showFore = ReadColor(input);
                Color showBack = ReadColor(input);

                this.DatFolder = DatFolder;
                this.name = name;
                this.confFolderPath = confFolderPath;
                this.HashedPass = hashedPass;
                this.HideFore = hideFore;
                this.HideBack = hideBack;
                this.ShowFore = showFore;
                this.ShowBack = showBack;
                this.Remarks = Remarks;
            }
        }
        private static string ReadString(FileStream stream)
        {
            byte[] buffer = new byte[4096];
            int length = 0;
            byte b;
            do
            {
                b = (byte)stream.ReadByte();
                buffer[length] = b;
                length++;
            } while (b != 0);
            return UTF8Encoding.UTF8.GetString(buffer, 0, length - 1);
        }
        private static Color ReadColor(FileStream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, 4);
            return Color.FromArgb(buffer[0], buffer[1], buffer[2], buffer[3]);
        }

        internal void CreateNewConf(string name, string confFolderPath, string password)
        {
            this.name = name;
            this.confFolderPath = confFolderPath;
            this.Password = password;
            this.SaveToFile();
        }
    }
}
