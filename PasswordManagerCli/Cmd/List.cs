using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerCli.Cmd
{
    using System.IO;

    class List : ICommand
    {
        public string command { get { return "list"; }}

        public string help { get { return "Show items"; }}
        public string[] HelpDetail(string applicationName) {
            return new string[] {
                String.Format("> {0} list [target_directory]", applicationName),
                "By default, target_directory is current directory."
            };
        }

        public void Invoke(string[] args)
        {
            string targetStr = args.Length < 2 ? "." : args[1];
            foreach (string item in Directory.EnumerateDirectories(targetStr))
            {
                if (!File.Exists(Path.Combine(item, "password")))
                {
                    NotPmDirectory();
                    return;
                }
                else
                {
                    if (targetStr == ".")
                    {
                        Console.WriteLine("\t{0}", new DirectoryInfo(item).Name);
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
        private static void NotPmDirectory()
        {
            Console.WriteLine("Invalid path");
        }
    }
}
