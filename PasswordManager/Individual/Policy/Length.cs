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
    using PasswordManager.Model;
    using PasswordManagerLib;

    public partial class Length : UserControl
    {
        public ItemPolicy Item
        {
            set
            {
                FromTo.DataBindings.Add(new Binding("Checked", value, "LengthWidth"));
                From.DataBindings.Add(new Binding("Value", value, "MinLength"));
                To.DataBindings.Add(new Binding("Value", value, "MaxLength"));
            }
        }
        public Length()
        {
            InitializeComponent();

            ToSetEnabled();
        }

        private void FromTo_CheckedChanged(object sender, EventArgs e)
        {
            if (! FromTo.Checked)
            {
                To.Value = From.Value;
            }
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

        private void From_ValueChanged(object sender, EventArgs e)
        {
            if (!FromTo.Checked || From.Value > To.Value)
            {
                To.Value = From.Value;
            }
        }

        private void To_ValueChanged(object sender, EventArgs e)
        {
            if (From.Value > To.Value)
            {
                To.Value = From.Value;
            }
        }
    }
}
