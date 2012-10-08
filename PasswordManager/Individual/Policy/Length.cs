using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Individual.Policy
{
    public partial class Length : UserControl
    {
        public Length()
        {
            InitializeComponent();

            ToSetEnabled();
        }

        private void FromTo_CheckedChanged(object sender, EventArgs e)
        {
            ToSetEnabled();
        }
        private void ToSetEnabled()
        {
            To.Enabled = FromTo.Checked;
        }

        public Tuple<int, int> GetLengthBand()
        {
            if (FromTo.Checked)
            {
                return new Tuple<int, int>((int)From.Value, (int)To.Value);
            }
            else
            {
                return new Tuple<int, int>((int)From.Value, (int)From.Value);
            }
        }
    }
}
