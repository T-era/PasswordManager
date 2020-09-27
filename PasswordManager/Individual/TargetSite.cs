using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Individual
{
    using System.Diagnostics;

    using PasswordManager.Model;
    using PasswordManager.GuiParts.Utility;
    using PasswordManagerLib;

    public partial class TargetSite : UserControl
    {
        private Binding locationBinding;
        private ItemPolicy item;
        public ItemPolicy Item
        {
            set
            {
                item = value;
                locationBinding = new Binding("Text", value, "Location");
                targetLink.DataBindings.Add(locationBinding);
            }
        }

        public TargetSite()
        {
            InitializeComponent();
        }

        private void targetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (item.LocationType == LocationType.URL)
            {
                Process.Start(item.Location);
            }
            else
            {
                Clipboard.SetText(item.Location);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            using (var window = new LocationChangeWindow()
            {
                Item = item,
            })
            {
                window.ShowDialog();
            }
        }
    }
}
