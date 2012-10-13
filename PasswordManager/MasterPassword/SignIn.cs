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

    public partial class SignIn : Form
    {
        public IMainConfig Config { set; get; }

        public SignIn()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            byte[] inputHash = PasswordFactory.ToHash(Input.Text);
            if (inputHash.SequenceEqual(Config.HashedPass))
            {
                Config.Password = Input.Text;
                return;
            }
            else
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("マスタパスが異なります");
            }
        }
    }
}
