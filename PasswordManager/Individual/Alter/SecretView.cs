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
    using PasswordManager.Individual.Password;

    public partial class SecretView : UserControl
    {
        private ItemPolicy item;
        public ItemPolicy Item
        {
            set
            {
                item = value;
                password1.Item = value;
                timestamp1.Item = value;
            }
        }
        public IMainConfig Config { set; private get; }

        public Color PasswordHideFore { set { this.password1.HideFore = value; } }
        public Color PasswordHideBack { set { this.password1.HideBack = value; } }
        public Color PasswordViewFore { set { this.password1.ViewFore = value; } }
        public Color PasswordViewBack { set { this.password1.ViewBack = value; } }

        public SecretView()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("新規パスワードを生成します。\n(パスワードを決定するとPolicyも保存します。)");
                using (var generateWindow = new GeneratorWindow()
                    {
                        Config = Config,
                        Item = item,
                    })
                {
                    generateWindow.CreatePassword(item, Config);
                    generateWindow.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
