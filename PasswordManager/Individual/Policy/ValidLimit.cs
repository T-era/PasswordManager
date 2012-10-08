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
    public partial class ValidLimit : UserControl
    {
        public ValidLimit()
        {
            InitializeComponent();
        }

        public int Days
        {
            get
            {
                if ("年".Equals(Unit.SelectedValue))
                {
                    return (int)Number.Value * 365;
                }
                else if ("月".Equals(Unit.SelectedValue))
                {
                    return (int)Number.Value * 30;
                }
                else
                {
                    return (int)Number.Value;
                }
            }
        }
    }
}