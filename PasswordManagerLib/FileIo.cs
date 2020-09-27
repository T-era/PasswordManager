using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManagerLib
{
    using System.Drawing;
    using System.IO;

    public static class FileIo
    {
        public static void WriteUtf8Bytes(FileStream stream, string str)
        {
            var bytes = UTF8Encoding.UTF8.GetBytes(str);
            stream.Write(bytes, 0, bytes.Length);
            stream.WriteByte(0);
        }
        public static void WriteColor(FileStream stream, Color color)
        {
            stream.WriteByte(color.A);
            stream.WriteByte(color.R);
            stream.WriteByte(color.G);
            stream.WriteByte(color.B);
        }
        public static void WriteLong(FileStream stream, long value)
        {
            var bits = BitConverter.GetBytes(value);
            stream.Write(bits, 0, bits.Length);
        }
        public static void WriteInt(FileStream stream, int value)
        {
            var bits = BitConverter.GetBytes(value);
            stream.Write(bits, 0, bits.Length);
        }
        public static void WriteByte(FileStream stream, byte value)
        {
            stream.WriteByte(value);
        }
        public static void WriteBytes(FileStream stream, byte[] value)
        {
            foreach (byte b in value)
            {
                WriteByte(stream, b);
            }
        }

        #region Read file
        public static string ReadString(FileStream stream)
        {
            byte[] buffer = new byte[16384];
            int length = 0;
            byte b;
            do
            {
                b = (byte)stream.ReadByte();
                buffer[length] = b;
                length++;
            } while (b != 0);
            return UTF8Encoding.UTF8.GetString(buffer, 0, length - 1);
        }
        public static Color ReadColor(FileStream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, 4);
            return Color.FromArgb(buffer[0], buffer[1], buffer[2], buffer[3]);
        }
        public static long ReadLong(FileStream stream)
        {
            int sizeOfLong = sizeof(long);
            byte[] buffer = new byte[sizeOfLong];
            stream.Read(buffer, 0, sizeOfLong);

            return BitConverter.ToInt64(buffer, 0);
        }
        public static int ReadInt(FileStream stream)
        {
            int sizeOfInt = sizeof(int);
            byte[] buffer = new byte[sizeOfInt];
            stream.Read(buffer, 0, sizeOfInt);

            return BitConverter.ToInt32(buffer, 0);
        }
        public static byte ReadByte(FileStream stream)
        {
            return (byte)stream.ReadByte();
        }
        public static byte[] ReadBytes(FileStream stream)
        {
            byte[] ret = new byte[stream.Length];
            stream.Read(ret, 0, ret.Length);
            return ret;
        }
        #endregion
    }
}
