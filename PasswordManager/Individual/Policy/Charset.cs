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

    public partial class Charset : UserControl
    {
        public Charset()
        {
            InitializeComponent();

            groupedCheckBox.Init(
                new [] {
                    new GroupedCheckBoxItem("数字", new string[] {}) { Replacer = "0 ～ 9" },
                    new GroupedCheckBoxItem("英字", new [] {"小文字", "大文字"}),
                    new GroupedCheckBoxItem("記号", new [] {
                        " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/",
                        ":", ";", "<", "=", ">", "?", "@",
                        "[", "\\", "]", "^", "_", "`", 
                        "{", "|", "}", "~"
                    }),
                });
        }
    }
}
