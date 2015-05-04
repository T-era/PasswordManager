using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManager
{
    using System.IO;

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
//args = new[] { @"C:\Users\Yoshi\Desktop\Private.ytel" };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var main = new MainConfig())
            {
                if (args.Length < 1 || string.IsNullOrEmpty(args[0]))
                {
                    using (var initForm = new InitForm())
                    {
                        var result = initForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            main.CreateNewConf(
                                initForm.ConfName,
                                initForm.ConfDir,
                                initForm.Password,
                                initForm.DataDir);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    if (File.Exists(args[0]))
                    {
                        main.ReadFromFile(args[0]);
                    }
                    else
                    {
                        MessageBox.Show("引数は任意。(指定する場合はマスタパスの設定ファイル");
                        return;
                    }
                }
                Application.Run(main);
            }
        }
    }
}
