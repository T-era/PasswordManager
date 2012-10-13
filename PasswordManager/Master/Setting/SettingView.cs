using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Master.Setting
{
    using PasswordManager.Model;

    public partial class SettingView : UserControl
    {
        private IMainConfig config;
        public IMainConfig Config
        {
            set
            {
                config = value;
                HideFore = config.HideFore;
                HideBack = config.HideBack;
                ShowFore = config.ShowFore;
                ShowBack = config.ShowBack;
                DataFolder = config.DatFolder;
                Remarks = config.Remarks;

                this.masterPassword1.Config = value;
            }
            get
            {
                return config;
            }
        }
        public Color HideFore
        {
            set { this.hideColorRegister.ForeColorPointed = value; }
            get { return this.hideColorRegister.ForeColorPointed; }
        }
        public Color HideBack
        {
            set { this.hideColorRegister.BackColorPointed = value; }
            get { return this.hideColorRegister.BackColorPointed; }
        }
        public Color ShowFore
        {
            set { this.focusColorRegister.ForeColorPointed = value; }
            get { return this.focusColorRegister.ForeColorPointed; }
        }
        public Color ShowBack
        {
            set { this.focusColorRegister.BackColorPointed = value; }
            get { return this.focusColorRegister.BackColorPointed; }
        }
        public string DataFolder
        {
            set { baseFolder.FolderPath = value; }
            get { return baseFolder.FolderPath; }
        }
        public string Remarks
        {
            set { this.RemarksInput.Text = value; }
            get { return this.RemarksInput.Text; }
        }

        public SettingView()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var main = FindParent<MainConfig>(this);
            Config.HideFore = HideFore;
            Config.HideBack = HideBack;
            Config.ShowFore = ShowFore;
            Config.ShowBack = ShowBack;
            Config.DatFolder = DataFolder;
            Config.Remarks = Remarks;

            main.SaveToFile();
        }

        private static T FindParent<T>(Control obj) where T : class
        {
            if (obj.Parent is T)
            {
                return obj.Parent as T;
            }
            else
            {
                return FindParent<T>(obj.Parent);
            }
        }
    }
}
