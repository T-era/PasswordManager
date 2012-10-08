using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.Security.Cryptography;

    class PasswordFactory
    {
        internal static byte[] ToHash(string password)
        {
            using (var encoder = SHA512.Create()) {
                byte[] passwordInAscii = ASCIIEncoding.ASCII.GetBytes(password);
                return encoder.ComputeHash(passwordInAscii);
            }
        }
    }
}
