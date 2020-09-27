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
    using PasswordManagerLib;

    public partial class Timestamp : UserControl
    {
        private Binding limitBinding;
        public ItemPolicy Item
        {
            set
            {
                limitBinding = new Binding("Text", value, "Limit");
                View.DataBindings.Add(limitBinding);
            }
        }

        public Timestamp()
        {
            InitializeComponent();
        }
    }
}
