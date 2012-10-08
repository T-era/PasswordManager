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
        private bool isAsAddNew;
        public bool IsAsAddNew
        {
            set
            {
                isAsAddNew = value;
                ViewName.ReadOnly = ! value;
            }
        }
        public string ConfName { get { return ViewName.Text; } }
        public string Password { get { return InputPassword.Text; } }
        public string ConfDir { get { return rootFolderDialog.SelectedPath; } }

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
    }
}
