using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.Security.Cryptography;

    class PasswordFactory
    {
        private const string HASH_IV_SEED = "This is my IV seed.";
        private const int SALT_LENGTH = 8;

        internal static byte[] ToHash(string password, IMainConfig config)
        {
            byte[] passwordArray = ASCIIEncoding.ASCII.GetBytes(password);
            using (var encoder = SHA512.Create())
            {
                for (int i = 0; i < 4; i++)
                {
                    byte[] passwordWithSalt = passwordArray.Concat(config.GetSalt()).ToArray();
                    passwordArray = encoder.ComputeHash(passwordWithSalt);
                }
                return passwordArray;
            }
        }
        internal static byte[] CreateNewSalt()
        {
            byte[] ret = new byte[SALT_LENGTH];
            new RNGCryptoServiceProvider().GetBytes(ret);
            return ret;
        }

        internal static byte[] ToCrypto(string password, string masterPass)
        {
            var crypt = GetCrypt(masterPass); 
            var encryptor = crypt.CreateEncryptor();

            var len = crypt.BlockSize;
            byte[] passByte = UTF8Encoding.UTF8.GetBytes(password);
            return encryptor.TransformFinalBlock(passByte, 0, passByte.Length);
        }
        internal static string FromCrypto(byte[] crypto, string masterPass)
        {
            var crypt = GetCrypt(masterPass);
            var decryptor = crypt.CreateDecryptor();
            
            char[] chars = UTF8Encoding.UTF8.GetChars(decryptor.TransformFinalBlock(crypto, 0, crypto.Length));
            return new string(chars);
        }

        private const string CONVERTER_IV_SEED = "This is my IV seed.";
        private const int CONVERTER_ITERATIONS = 3;
        private static readonly byte[] CONVERTER_SALT = new byte[] { 12, 52, 3, 241, 1, 132, 45, 94 };
        private static SymmetricAlgorithm GetCrypt(string masterPass)
        {
            SymmetricAlgorithm crypt = new RijndaelManaged();
            var master = new Rfc2898DeriveBytes(UTF32Encoding.UTF32.GetBytes(masterPass), CONVERTER_SALT, CONVERTER_ITERATIONS).GetBytes(crypt.KeySize / 8);
            byte[] iv = ASCIIEncoding.ASCII.GetBytes(CONVERTER_IV_SEED.ToCharArray(), 0, crypt.BlockSize / 8);
            crypt.Key = master;
            crypt.IV = iv;
            return crypt;
        }
    }
}
