using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerCli
{
    using System.Security;
    using Cmd;
    using Input;

    interface ICommand {
        string command { get; }
        string help { get; }
        string[] HelpDetail(string applicationName);
        void Invoke(string[] args);
    }
    class Program
    {
        private static readonly ICommand[] COMMAND = { new List(), new Show() };
        static void Main(string[] args)
        {
            if (args.Length <= 0) {
                ShowHelp();
            } else {
                string arg1 = args[0].ToLower();
                // 指定されなければデフォルトは、COMMAND先頭
                ICommand cmd = null;
                foreach (ICommand item in COMMAND) {
                    if (item.command == arg1) {
                        cmd = item;
                    }
                }
                if (cmd == null) {
                    ShowHelp();
                } else {
                    cmd.Invoke(args);
                }
            }
        }
        private static void ShowHelp()
        {
            string app = Environment.GetCommandLineArgs()[0];
            Console.WriteLine("PasswordManager CLI tool.");
            Console.WriteLine("> {0} {{CMD}} {{ARGUMENTS..}}", app);
            Console.WriteLine("CMD:");
            foreach (ICommand cmd in COMMAND)
            {
                Console.WriteLine("\t{0}: {1}", cmd.command, cmd.help);
                foreach (string helpLine in cmd.HelpDetail(app))
                {
                    Console.WriteLine("\t\t{0}", helpLine);
                }
            }
        }
    }
}
