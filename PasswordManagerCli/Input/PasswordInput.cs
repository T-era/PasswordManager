using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerCli.Input
{
    using System.Security;
    
    static class PasswordInput
    {
        private static readonly int MAX_LENGTH = 100;
        internal static string ReadConsole()
        {
            return ReadConsole(null);
        }
        internal static string ReadConsole(string prompt)
        {
            if (prompt != null)
            {
                Console.Write(prompt);
            }
            IList<char> result = new List<char>();
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return new string(result.ToArray());
                }
                else if (input.Key == ConsoleKey.Backspace)
                {
                    if (result.Count > 0)
                    {
                        result.RemoveAt(result.Count - 1);
                    }
                }
                else if (input.Key == ConsoleKey.Escape)
                {
                    return null;
                }
                else if (byte.MinValue <= input.KeyChar && input.KeyChar < byte.MaxValue)
                {
                    Console.Write("*");
                    result.Add(input.KeyChar);
                }
            }
        }
    }
}
