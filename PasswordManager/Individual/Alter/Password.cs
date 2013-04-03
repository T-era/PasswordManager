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
    using PasswordManager.Model;

    public partial class Password : UserControl
    {
        private Binding passwordBinding;
        public ItemPolicy Item
        {
            set {
                passwordBinding = new Binding("Text", value, "Password");
                View.DataBindings.Add(passwordBinding);
            }
        }

        public Color HideFore { set; get; }
        public Color HideBack { set; get; }
        public Color ViewFore { set; get; }
        public Color _viewBack;
        public Color ViewBack
        {
            set { _viewBack = value; SetColor(false); }
            get { return _viewBack; }
        }

        public Password()
        {
            InitializeComponent();
        }

        private void View_Enter(object sender, EventArgs e)
        {
            SetColor(true);
        }

        private void View_Leave(object sender, EventArgs e)
        {
            SetColor(false);
        }

        public void SetColor(bool show)
        {
            if (show)
            {
                View.ForeColor = ViewFore;
                View.BackColor = ViewBack;
            }
            else
            {
                View.ForeColor = HideFore;
                View.BackColor = HideBack;
            }
        }
    }
}
