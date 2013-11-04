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
        private readonly IDictionary<ItemPolicy, IndividualWindow> OpenedWindows = new Dictionary<ItemPolicy, IndividualWindow>();
        private IMainConfig config;
        public IMainConfig Config
        {
            set
            {
                config = value;
                SignInButton.JointToMainConfig(config);
                this.ListView.DataSource = value.Items;
                config.PasswordLocked += this.CloseAllWindow;
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
            var newPolicy = AddNewItem(this.Config);
            OpenWindow(newPolicy);
        }
        internal static ItemPolicy AddNewItem(IMainConfig config)
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

                    return newPolicy;
                }
                else
                {
                    return null;
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
            OpenWindow(item);
        }
        private void OpenWindow(ItemPolicy item)
        {
            if (OpenedWindows.ContainsKey(item))
            {
                OpenedWindows[item].Focus();
            }
            else
            {
                var window = new IndividualWindow()
                {
                    Name = item.Name,
                    Text = item.Name,
                    Config = Config,
                    Item = item,
                };
                OpenedWindows.Add(item, window);
                window.Show();
            }
        }
        private void CloseAllWindow()
        {
            foreach (var entry in OpenedWindows)
            {
                entry.Value.Close();
            }
            OpenedWindows.Clear();
        }
    }
}
