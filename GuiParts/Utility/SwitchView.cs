using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.GuiParts.Utility
{
    using System.Collections.Generic;

    public partial class SwitchView : UserControl
    {
        public SwitchView()
        {
            InitializeComponent();
        }
        public void SetControls(IList<SwitchViewItem> controls)
        {
            foreach (var svi in controls)
            {
                this.comboBox1.Items.Add(svi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchViewItem selected = (SwitchViewItem)comboBox1.SelectedItem;
            Control uc = selected.Control;
            if (selected.AllowPanelSize)
            {
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                uc.Width = panel1.Width;
                uc.Height = panel1.Height;
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }

    public class SwitchViewItem
    {
        public string Label { set; get; }
        public Control Control { set; get; }
        public bool AllowPanelSize { set; get; }
        public override string ToString()
        {
            return Label;
        }
    }
}
