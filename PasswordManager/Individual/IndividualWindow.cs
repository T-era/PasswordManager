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
    using PasswordManager.Model;
    using PasswordManagerLib;

    public partial class IndividualWindow : Form
    {
        public ItemPolicy Item
        {
            set
            {
                settingView1.Item = value;
                targetSite1.Item = value;
                secretView1.Item = value;
                this.Remarks.DataBindings.Add(new Binding("Text", value, "Remarks"));
            }
        }
        public Model.IMainConfig Config
        {
            set
            {
                PasswordHideBack = value.HideBack;
                PasswordHideFore = value.HideFore;
                PasswordViewBack = value.ShowBack;
                PasswordViewFore = value.ShowFore;
                settingView1.Config = value;
                secretView1.Config = value;
            }
        }
        public Color PasswordHideFore { set { this.secretView1.PasswordHideFore = value; } }
        public Color PasswordHideBack { set { this.secretView1.PasswordHideBack = value; } }
        public Color PasswordViewFore { set { this.secretView1.PasswordViewFore = value; } }
        public Color PasswordViewBack { set { this.secretView1.PasswordViewBack = value; } }

        public IndividualWindow()
        {
            InitializeComponent();
        }
    }
}
