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
    public partial class ColorRegister : UserControl
    {
        public Color ForeColorPointed {
            get { return Sample.ForeColor; }
            set { Sample.ForeColor = value; }
        }
        public Color BackColorPointed {
            get { return Sample.BackColor; }
            set { Sample.BackColor = value; }
        }

        [Browsable(true)]
        [Category("表示")]
        public string Title
        {
            set { Label.Text = value; }
            get { return Label.Text; }
        }

        public ColorRegister()
        {
            InitializeComponent();
        }

        private void buttonFore_Click(object sender, EventArgs e)
        {
            var result = foreColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ForeColorPointed = foreColorDialog.Color;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var result = backColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColorPointed = backColorDialog.Color;
            }
        }
    }
}
