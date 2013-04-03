using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Master.Listup
{
    using PasswordManager.Individual;
    using PasswordManager.MasterPassword;
    using PasswordManager.Model;

    public partial class IndividualList : UserControl
    {
        private IMainConfig config;
        public IMainConfig Config
        {
            set
            {
                config = value;
                this.ListView.DataSource = value.Items;
            }
            get { return config; }
        }

        public IndividualList()
        {
            InitializeComponent();
        }

        private void ListViewShowAlert(object o, DataGridViewCellFormattingEventArgs args)
        {
            // 日付チェック(警告色)
            if (args.ColumnIndex == 1)
            {
                DataGridView dgv = (DataGridView)o;
                if (args.Value != null && (DateTime)args.Value < DateTime.Now)
                {
                    dgv.Rows[args.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dgv.Rows[args.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            AddNewItem(this.Config);
        }
        internal static void AddNewItem(IMainConfig config)
        {
            using (var init = new PasswordManager.Individual.InitForm()
            {
                Config = config,
            })
            {
                var result = init.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ItemPolicy newPolicy = ItemPolicy.CreateNewItem(init.ViewName);
                    newPolicy.Location = init.LocationIn;
                    newPolicy.LocationType = init.LocationType;
                    newPolicy.SaveToFile(config.DatFolder);
                    config.Items.Add(newPolicy);

                    new IndividualWindow()
                    {
                        Name = init.ViewName,
                        Text = init.ViewName,
                        Config = config,
                        Item = newPolicy,
                    }.Show();
                }
            }
        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            ItemPolicy item = (ItemPolicy)ListView.SelectedRows[0].DataBoundItem;
            if (item.HasPasswordFile(config.DatFolder))
            {
                if (!Config.IsPasswordConfirmed)
                {
                    using (var signIn = new SignIn() { Config = config })
                    {
                        var result = signIn.ShowDialog();
                        if (result != DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                item.ReadPassword(config.Password, config.DatFolder);
            }
            new IndividualWindow()
            {
                Name = item.Name,
                Text = item.Name,
                Config = Config,
                Item = item,
            }.Show();
        }
    }
}
