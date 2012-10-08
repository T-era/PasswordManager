using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManager
{
    using PasswordManager.MasterPassword;
    using PasswordManager.Master;
    using PasswordManager.Model;

    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
args = new[] { @"D:\Bk_Yoshi\Vs\PasswordManager\PasswordManager\bin\Debug\test.ytel" };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length < 1 || string.IsNullOrEmpty(args[0]))
            {
                using (var initForm = new InitForm())
                {
                    var result = initForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MasterConf.CreateNewConf(
                            initForm.ConfName,
                            initForm.ConfDir,
                            PasswordFactory.ToHash(initForm.Password));

                        Application.Run(new MainConfig());
                    }
                }
            }
            else
            {
                if (System.IO.File.Exists(args[0]))
                {
                    MasterConf.ReadFromFile(args[0]);
                    Application.Run(new MainConfig());
                }
                else
                {
                    MessageBox.Show("TODO:USAGE");
                }
            }
        }
    }
}
