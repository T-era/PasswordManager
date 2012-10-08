using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Individual.Alter
{
    public partial class SecretView : UserControl
    {
        public Color PasswordHideFore { set { this.password1.HideFore = value; } }
        public Color PasswordHideBack { set { this.password1.HideBack = value; } }
        public Color PasswordViewFore { set { this.password1.ViewFore = value; } }
        public Color PasswordViewBack { set { this.password1.ViewBack = value; } }

        public SecretView()
        {
            InitializeComponent();
        }
    }
}
