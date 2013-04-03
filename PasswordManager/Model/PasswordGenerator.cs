using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.Security.Cryptography;

    class PasswordGenerator
    {
        private readonly ItemPolicy item;
        private readonly byte charValiation;
        /// <summary>
        /// 暗号乱数 パスワード生成用
        /// </summary>
        private readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        internal PasswordGenerator(ItemPolicy item)
        {
            this.item = item;
            this.charValiation = (byte)item.UsableChars.Count;// ASCII なので、高々byte
        }

        internal string Generate()
        {
            int length = DecideLength();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = PickChar();
            }
            return new string(chars);
        }
        private char PickChar()
        {
            byte[] seed = new byte[4];
            int turn = 256 * 4 / charValiation;
            int rnd;
            do
            {
                rng.GetBytes(seed);
                rnd = BitConverter.ToInt32(seed, 0);
            } while (rnd <= charValiation * turn);
            return item.UsableChars[rnd % charValiation];
        }

        /// <summary>
        /// 非暗号乱数。パスワード生成には使用できない。
        /// </summary>
        private readonly Random rndForLength = new Random();
        private int DecideLength()
        {
            if (item.MinLength == item.MaxLength)
            {
                return item.MinLength;
            }
            int span = item.MaxLength - item.MinLength + 1;
            return item.MinLength + rndForLength.Next(span);
        }
    }
}
