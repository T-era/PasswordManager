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
    public partial class FolderSelector : UserControl
    {
        [Category("表示")]
        public string Title
        {
            set { Label.Text = value; }
            get { return Label.Text; }
        }
        public string FolderPath
        {
            set { View.Text = value; }
            get { return View.Text; }
        }
        public FolderSelector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                View.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
