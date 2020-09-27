using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerCli.Cmd
{
    using System.IO;
    using PasswordManagerLib;
    using Input;

    class Show : ICommand
    {
        public string command { get { return "show"; }}

        public string help { get { return "Show password"; }}
        public string[] HelpDetail(string applicationName) {
            return new string[] {
                String.Format("> {0} show {{target directory}}", applicationName)
            };
        }

        public void Invoke(string[] args)
        {
            string target = args[1];
            string mp = PasswordInput.ReadConsole("Master Pass:");

            using (FileStream stream = new FileStream(Path.Combine(target, "password"), FileMode.Open)) {
                byte[] crypto = FileIo.ReadBytes(stream);
                Console.WriteLine(PasswordFactory.FromCrypto(crypto, mp));
            }
        }
    }
}
