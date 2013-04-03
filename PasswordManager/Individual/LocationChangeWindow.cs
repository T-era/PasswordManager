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
    using PasswordManager.Model;

    public partial class LocationChangeWindow : Form
    {
        private ItemPolicy item;
        public ItemPolicy Item
        {
            set
            {
                item = value;
                InputLocationType.SelectedItem = value.LocationType;
                InputLocation.Text = value.Location;
            }
        }

        public LocationChangeWindow()
        {
            InitializeComponent();

            InputLocationType.Items.Add(LocationType.URL);
            InputLocationType.Items.Add(LocationType.その他);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (InputLocationType.SelectedItem == null)
            {
                MessageBox.Show("Type 選ぶ");
                DialogResult = DialogResult.None;
            }
            item.LocationType = (LocationType)InputLocationType.SelectedItem;
            item.Location = InputLocation.Text;
        }
    }
}
