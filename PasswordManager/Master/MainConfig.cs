using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Master
{
    using PasswordManager.Model;

    public partial class MainConfig : Form
    {
        public MainConfig()
        {
            InitializeComponent();

            this.Shown += (o, e) =>
            {
                var conf = MasterConf.SingletonObject;
                Text = conf.Name;
                Name = conf.Name;
                settingView.HideFore = conf.HideFore;
                settingView.HideBack = conf.HideBack;
                settingView.ShowFore = conf.ShowFore;
                settingView.ShowBack = conf.ShowBack;
                settingView.DataFolder = conf.DatFolder;
                settingView.Remarks = conf.Remarks;
            };
        }
    }
}
