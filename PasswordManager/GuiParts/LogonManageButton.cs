using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.GuiParts
{
    using System.Drawing;
    using System.Windows.Forms;

    using PasswordManager.Model;
    using PasswordManager.MasterPassword;

    internal sealed class LogonManageButton : Button
    {
        private static readonly Color NOT_CONFIRMED = Color.FromArgb(64, 255, 0, 0);
        private static readonly Color LOGGED = Color.FromArgb(64, 0, 0, 255);
        private static readonly Color LOCKED = Color.FromArgb(64, 128, 0, 128);
        private bool logged = false;
        private bool locked = false;
        internal Func<bool> LogonAction { set; get; }
        internal Func<bool> LockOutAction { set; get; }

        public LogonManageButton()
        {
            BackColor = NOT_CONFIRMED;
            Text = "Not logged";
            FlatStyle = FlatStyle.Popup;
        }

        internal void setLogged()
        {
            logged = true;
            locked = false;
            BackColor = LOGGED;
            Text = "Logged";
        }
        internal void setLocked()
        {
            if (logged)
            {
                locked = true;
                BackColor = LOCKED;
                Text = "Locked";
            }
            else
                throw new Exception();
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (!logged)
            {
                if (LogonAction())
                {
                    setLogged();
                }
            }
            else
            {
                if (locked)
                {
                    if (LogonAction())
                    {
                        setLogged();
                    }
                }
                else
                {
                    if (LockOutAction())
                    {
                        setLocked();
                    }
                }
            }
        }
        internal void JointToMainConfig(IMainConfig config)
        {
            config.PasswordConfirmed += setLogged;
            config.PasswordLocked += setLocked;
            LogonAction = () =>
            {
                using (var signIn = new SignIn())
                {
                    signIn.Config = config;
                    var result = signIn.ShowDialog();
                    return result == DialogResult.OK;
                }
            };
            LockOutAction = () =>
            {
                config.Password = null;

                return true;
            };
        }
    }
}
