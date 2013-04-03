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

    public partial class SettingView : UserControl
    {
        private ItemPolicy item;
        public ItemPolicy Item
        {
            set {
                validLimit1.Item = value;
                length1.Item = value;
                charset1.Item = value;
                item = value;
            }
        }
        public IMainConfig Config { set; private get; }

        public SettingView()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            item.SaveToFile(Config.DatFolder);
        }
    }
}
