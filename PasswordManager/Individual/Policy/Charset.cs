using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager.Individual.Policy
{
    using PasswordManager.GuiParts.Utility;
    using PasswordManager.Model;
    using PasswordManagerLib;

    public partial class Charset : UserControl
    {
        private ItemPolicy item;
        public ItemPolicy Item {
            set {
                item = value;
                alphabetGroup.GetCheckBoxItem("大文字").Checked = value.UsableChars.Contains('A');
                alphabetGroup.GetCheckBoxItem("小文字").Checked = value.UsableChars.Contains('a');
                foreach (char c in ItemPolicy.CHARS_SIGNS) {
                    signGroup.GetCheckBoxItem(c).Checked = value.UsableChars.Contains(c);
                }
            }
        }

        private GroupedCheckBoxItem<string> alphabetGroup;
        private GroupedCheckBoxItem<char> signGroup;
        public Charset()
        {
            InitializeComponent();

            var gcbiNumber = new GroupedCheckBoxItem<string>("数字", new string[] { }) { Replacer = "0 ～ 9" };
            gcbiNumber.ParentCheckBoxChanged += (b) => { item.AllowNumber = b; };
            alphabetGroup = new GroupedCheckBoxItem<string>("英字", new[] { "小文字", "大文字" });
            alphabetGroup.ParentCheckBoxChanged += (b) => { item.AllowAlphabet = b; };
            alphabetGroup.ChildCheckBoxChanged += (i, b) =>
            {
                char[] charset;
                if (string.Equals("小文字", i))
                {
                    charset = ItemPolicy.CHARS_LOWER;
                }
                else if (string.Equals("大文字", i))
                {
                    charset = ItemPolicy.CHARS_UPPER;
                }
                else
                {
                    throw new Exception();
                }
                if (b)
                {
                    item.AddAllUsableChars(charset);
                }
                else
                {
                    item.RemoveAllUsableChars(charset);
                }
            };
            signGroup = new GroupedCheckBoxItem<char>("記号", ItemPolicy.CHARS_SIGNS);
            signGroup.ParentCheckBoxChanged += (b) => { item.AllowSign = b; };
            signGroup.ChildCheckBoxChanged += (i, b) =>
            {
                if (b)
                {
                    item.AddAllUsableChars(new char[] { (char)i });
                }
                else
                {
                    item.RemoveAllUsableChars(new char[] { (char)i });
                }
            };
            groupedCheckBox.Init(
                new IGroupedCheckBoxItem[] {
                    gcbiNumber, alphabetGroup, signGroup
                });
        }
    }
}
