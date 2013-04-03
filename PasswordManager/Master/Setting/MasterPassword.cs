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
    using PasswordManager.MasterPassword;

    public partial class MasterPassword : UserControl
    {
        private static readonly Color NOT_CONFIRMED = Color.FromArgb(64, 255, 0, 0);
        private static readonly Color CONFIRMED = Color.FromArgb(64, 0, 0, 255);
        private IMainConfig config;
        public IMainConfig Config
        {
            set {
                config = value;
                config.PasswordConfirmed += () =>
                {
                    SignIn.BackColor = CONFIRMED;
                    SignIn.Text = "Logged";
                };
            }
            get { return config; }
        }

        public MasterPassword()
        {
            InitializeComponent();

            SignIn.BackColor = NOT_CONFIRMED;
            SignIn.Text = "Not logged";
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            using (var signIn = new SignIn())
            {
                signIn.Config = this.Config;
                signIn.ShowDialog();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            ChangePassword(this.Config);
        }
        internal static void ChangePassword(IMainConfig config)
        {
            if (!config.IsPasswordConfirmed)
            {
                using (var signIn = new SignIn())
                {
                    signIn.Config = config;
                    signIn.ShowDialog();
                    if (signIn.DialogResult != DialogResult.OK)
                    {
                        // 認証不通過。
                        return;
                    }
                }
            }
            using (var changePassword = new InitForm()
            {
                IsAsAddNew = false,
                ConfName = config.ConfName,
            })
            {
                changePassword.ShowDialog();
                if (changePassword.DialogResult == DialogResult.OK)
                {
                    string newPassword = changePassword.Password;
                    string oldPassword = config.Password;
                    foreach (ItemPolicy item in config.Items)
                    {
                        item.ResavePassword(oldPassword, newPassword, config.DatFolder);
                    }
                    config.Password = newPassword;
                    config.DatFolder = config.DatFolder;
                    config.SaveToFile();
                }
            }
        }
    }
}
