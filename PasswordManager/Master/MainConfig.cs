using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Master
{
    using PasswordManager.Model;

    public partial class MainConfig : Form
    {
        public MainConfig()
        {
            InitializeComponent();

            this.Shown += (o, e) =>
            {
                Text = this.name;
                Name = this.name;
                settingView.Config = this;
            };
        }
    }
}
