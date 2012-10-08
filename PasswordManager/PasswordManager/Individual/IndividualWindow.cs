using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Individual
{
    using PasswordManager.GuiParts.Utility;

    public partial class IndividualWindow : Form
    {
        public Color PasswordHideFore { set { this.secretView1.PasswordHideFore = value; } }
        public Color PasswordHideBack { set { this.secretView1.PasswordHideBack = value; } }
        public Color PasswordViewFore { set { this.secretView1.PasswordViewFore = value; } }
        public Color PasswordViewBack { set { this.secretView1.PasswordViewBack = value; } }

        private SwitchViewItem Url = new SwitchViewItem()
        {
            Label = "URL",
            Control = new LinkLabel(),
            AllowPanelSize = true,
        };
        private SwitchViewItem Other = new SwitchViewItem()
        {
            Label = "その他",
            Control = new TextBox() { ReadOnly = true },
            AllowPanelSize = true,
        };

        public IndividualWindow()
        {
            InitializeComponent();

            targetSite1.switchView1.SetControls(new[] { Url, Other });
        }
    }
}
