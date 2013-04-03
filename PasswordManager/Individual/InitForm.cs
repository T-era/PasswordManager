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
        private IMainConfig config;
        public IMainConfig Config {
            set
            {
                config = value;
                DatDirectory = new DirectoryInfo(config.DatFolder);
            }
            get { return config; }
        }
        private DirectoryInfo DatDirectory { set; get; }

        public string ViewName { get { return InputName.Text; } }
        public string LocationIn { get { return InputLocation.Text; } }
        public LocationType LocationType { get { return (LocationType)InputType.SelectedItem; } }

        public InitForm()
        {
            InitializeComponent();

            InputType.Items.Add(LocationType.URL);
            InputType.Items.Add(LocationType.その他);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string name = InputName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("名前を決めて");
                DialogResult = DialogResult.None;
            }
            if (DirectoryExists(name))
            {
                MessageBox.Show("データフォルダに同名の要素がある");
                DialogResult = DialogResult.None;
            }
            if (InputType.SelectedItem == null)
            {
                MessageBox.Show("ロケーションの種類を選ぶ");
                DialogResult = DialogResult.None;
            }
            else
            {
                DirectoryCreate(name);
            }
        }

        private bool DirectoryExists(string name)
        {
            var query = DatDirectory.GetDirectories().Where(t => t.Name == name);
            return query.Count() != 0;
        }
        private void DirectoryCreate(string name)
        {
            DatDirectory.CreateSubdirectory(name);
        }
    }
}
