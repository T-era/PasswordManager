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
            var conf = MasterConf.SingletonObject;
            conf.HideFore = HideFore;
            conf.HideBack = HideBack;
            conf.ShowFore = ShowFore;
            conf.ShowBack = ShowBack;
            conf.DatFolder = DataFolder;
            conf.Remarks = Remarks;

            conf.SaveToFile();
        }
    }
}
