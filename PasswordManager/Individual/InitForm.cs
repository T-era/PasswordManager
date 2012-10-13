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
    using System.IO;

    using PasswordManager.Model;

    public partial class InitForm : Form
    {
        public IMainConfig Config { set; get; }

        public InitForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string name = InputName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("名前を決めて");
                return;
            }
            if (DirectoryExists(name))
            {
                MessageBox.Show("データフォルダに同名の要素がある");
                return;
            }
        }

        private bool DirectoryExists(string name)
        {
            DirectoryInfo dir = new DirectoryInfo(Config.DatFolder);
            var query = dir.GetDirectories().Where(t => t.Name == name);
            return query.Count() != 0;
        }
    }
}
