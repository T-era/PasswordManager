using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Individual.Password
{
    using PasswordManager.Model;
    using PasswordManager.MasterPassword;
    using PasswordManagerLib;

    public partial class GeneratorWindow : Form
    {
        private ItemPolicy item;
        private Model.IMainConfig config;
        public ItemPolicy Item { set { item = value; } }
        public Model.IMainConfig Config { set { config = value; } }

        public GeneratorWindow()
        {
            InitializeComponent();
        }

        public void CreatePassword(ItemPolicy item, Model.IMainConfig config)
        {
            this.item = item;
            this.config = config;

            PasswordGenerator generator = new PasswordGenerator(item);
            textBox1.Text = generator.Generate();
            textBox2.Text = generator.Generate();
            textBox3.Text = generator.Generate();
        }

        private void useThis1_Click(object sender, EventArgs e)
        {
            SaveNewPassword(textBox1.Text);
        }

        private void useThis2_Click(object sender, EventArgs e)
        {
            SaveNewPassword(textBox2.Text);
        }

        private void useThis3_Click(object sender, EventArgs e)
        {
            SaveNewPassword(textBox3.Text);
        }
        private void SaveNewPassword(string newPassword)
        {
            if (! config.IsPasswordConfirmed) 
            {
                using (var signIn = new SignIn()
                {
                    Config = config,
                })
                {
                    var result = signIn.ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        MessageBox.Show("マスタパスワードが違う");
                        return;
                    }
                }
            }
            item.Limit = DateTime.Now + item.LimitSpan();
            item.SaveToFile(config.DatFolder);
            item.SavePassword(newPassword, config.Password, config.DatFolder);
            DialogResult = DialogResult.OK;
        }
    }
}
