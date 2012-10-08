using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Individual.IndividualWindow()
            {
                PasswordHideBack = Color.FromArgb(255, 112, 0, 0),
                PasswordHideFore = Color.FromArgb(255, 32, 0, 0),
                PasswordViewBack = Color.White,
                PasswordViewFore = Color.Black,
            }.ShowDialog();
        }
    }
}
