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

    public partial class ValidLimit : UserControl
    {
        public ItemPolicy Item
        {
            set {
                Unit.DataBindings.Add(new Binding("SelectedItem", value, "TermUnit"));
                Number.DataBindings.Add(new Binding("Value", value, "Term"));
            }
        }

        public ValidLimit()
        {
            InitializeComponent();

            Unit.Items.Add(Terms.年);
            Unit.Items.Add(Terms.月);
            Unit.Items.Add(Terms.週);
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