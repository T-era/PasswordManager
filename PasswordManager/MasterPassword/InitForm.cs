using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.MasterPassword
{
    using PasswordManager.Model;

    public partial class InitForm : Form
    {
        const string CONF_FILE_PATH = "{0}\\{1}.ytel";
        private bool isAsAddNew;
        public bool IsAsAddNew
        {
            set
            {
                isAsAddNew = value;
                ViewName.ReadOnly = !value;
                selectRoot.Enabled = value;
                DataFolder.ReadOnly = !value;
                selectDataFolder.Enabled = value;
            }
        }
        public string ConfName
        {
            get {
                return ViewName.Text;
            }
            set {
                ViewName.Text = value;
                ViewMasterFile.Text = string.Format(CONF_FILE_PATH, confDir, value);
            }
        }
        public string Password { get { return InputPassword.Text; } }

        public string DataDir
        {
            private set { DataFolder.Text = value; }
            get { return DataFolder.Text; }
        }
        private string confDir;
        public string ConfDir
        {
            private set
            {
                confDir = value;
                ViewMasterFile.Text = string.Format(CONF_FILE_PATH, value, ConfName);
            }
            get { return confDir; }
        }

        public InitForm()
        {
            InitializeComponent();

            rootFolderDialog.SelectedPath = Application.StartupPath;
        }

        private void selectRoot_Click(object sender, EventArgs e)
        {
            var result = rootFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ConfDir = rootFolderDialog.SelectedPath;
                DataDir = confDir + "\\ytel";
            }
        }

        private void selectDataFolder_Click(object sender, EventArgs e)
        {
            var result = dataFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataDir = dataFolderDialog.SelectedPath;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ViewName.Text))
            {
                MessageBox.Show("名前を決めること");
                this.DialogResult = DialogResult.None;
            }
            else if (string.IsNullOrEmpty(InputPassword.Text))
            {
                MessageBox.Show("マスタ パスワードを決めること");
                this.DialogResult = DialogResult.None;
            }
            else if (!string.Equals(InputPassword.Text, InputAgain.Text))
            {
                MessageBox.Show("マスタ パスワードを再確認すること");
                this.DialogResult = DialogResult.None;
            }
        }

        private void ViewName_TextChanged(object sender, EventArgs e)
        {
            ViewMasterFile.Text = string.Format(CONF_FILE_PATH, confDir, ViewName.Text);
        }
    }
}
