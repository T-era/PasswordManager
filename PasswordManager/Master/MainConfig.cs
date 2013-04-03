using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Master
{
    using PasswordManager.Master.Setting;
    using PasswordManager.Master.Listup;
    using PasswordManager.Model;

    public partial class MainConfig : Form
    {
        public MainConfig()
        {
            InitializeComponent();

            this.Shown += (o, e) =>
            {
                Text = this.name;
                Name = this.name;
                settingView.Config = this;
                individualList.Config = this;
            };
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveToFile();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterPassword.ChangePassword(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualList.AddNewItem(this);
        }
    }
}
