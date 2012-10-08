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
    public partial class GroupedCheckBox : UserControl
    {
        private const int CHECKBOX_WIDTH = 20;
        private const int CHECKBOX_LEFT = 5;
        private const int CHECKBOX_TOP = 3;
        private const int PARENT_HEIGHT = 30;
        private static readonly Color COLLASP = Color.FromArgb(0, 0, 0, 0);
        private static readonly Color LABEL_CHECKED = Color.FromArgb(255, 140, 140, 140);
        private static readonly Color LABEL_MOUSE_DOWN = Color.FromArgb(255, 128, 128, 128);
        private static readonly Color LABEL_MOUSE_OVER = Color.FromArgb(8, 0, 0, 255);

        public GroupedCheckBox()
        {
            InitializeComponent();
        }

        public void Init(IList<GroupedCheckBoxItem> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                var checkBox = item.Parent;
                checkBox.Location = new Point { X = CHECKBOX_LEFT, Y = CHECKBOX_TOP };
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                checkBox.Width = CHECKBOX_WIDTH;
                checkBox.BackColor = COLLASP;

                var label = new RadioButton() { Text = item.ParentLabel };
                label.Appearance = Appearance.Button;
                label.FlatStyle = FlatStyle.Flat;
                label.Padding = new Padding(CHECKBOX_WIDTH + CHECKBOX_LEFT, 0, 0, 0);
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.FlatAppearance.BorderColor = SystemColors.Control;
                label.FlatAppearance.CheckedBackColor = LABEL_CHECKED;
                label.FlatAppearance.MouseDownBackColor = LABEL_MOUSE_DOWN;
                label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                label.Location = new Point() { Y = i * PARENT_HEIGHT, X = 0 };
                label.Height = PARENT_HEIGHT;
                label.Width = panel1.Width;

                EventHandler action = (o, e) =>
                {
                    panel2.Controls.Clear();
                    if (item.Childs.Count == 0)
                    {
                        panel2.Controls.Add(new Label()
                        {
                            Text = item.Replacer,
                            Location = new Point(3, 3),
                        });
                    }
                    else
                    {
                        for (int j = 0; j < item.Childs.Count; j++)
                        {
                            int x = j % 4;
                            int y = j / 4;
                            var child = item.Childs[j];
                            child.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                            child.Location = new Point(3 + x * 70, 3 + y * 20);
                            child.Width = 65;
                            panel2.Controls.Add(child);
                        }
                    }

                    foreach (var c in item.Childs)
                    {
                        panel2.Controls.Add(c);
                    }
                };
                checkBox.GotFocus += action;
                label.GotFocus += action;

                this.panel1.Controls.Add(label);
                label.Controls.Add(checkBox);
            }
        }
    }
    public class GroupedCheckBoxItem
    {
        public string ParentLabel { private set; get; }
        public CheckBox Parent { private set; get; }
        public IList<CheckBox> Childs { private set; get; }
        public string Replacer { set; get; }

        public GroupedCheckBoxItem(string parentLabel, IList<string> childs)
        {
            ParentLabel = parentLabel;

            Childs = new List<CheckBox>();
            foreach (string cLabel in childs)
            {
                Childs.Add(new CheckBox() {
                    Text = cLabel,
                    Checked = true,
                });
            }
            Parent = new CheckBox()
            {
                Checked = true,
            };
            Parent.CheckedChanged += (o, e) =>
            {
                foreach (var cb in Childs)
                {
                    cb.Enabled = Parent.Checked;
                }
            };
        }
    }
}
