using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.Drawing;
    using System.IO;

    static class FileIo
    {
        internal static void WriteUtf8Bytes(FileStream stream, string str)
        {
            var bytes = UTF8Encoding.UTF8.GetBytes(str);
            stream.Write(bytes, 0, bytes.Length);
            stream.WriteByte(0);
        }
        internal static void WriteColor(FileStream stream, Color color)
        {
            stream.WriteByte(color.A);
            stream.WriteByte(color.R);
            stream.WriteByte(color.G);
            stream.WriteByte(color.B);
        }
        internal static void WriteLong(FileStream stream, long value)
        {
            var bits = BitConverter.GetBytes(value);
            stream.Write(bits, 0, bits.Length);
        }
        internal static void WriteInt(FileStream stream, int value)
        {
            var bits = BitConverter.GetBytes(value);
            stream.Write(bits, 0, bits.Length);
        }
        internal static void WriteByte(FileStream stream, byte value)
        {
            stream.WriteByte(value);
        }
        internal static void WriteBytes(FileStream stream, byte[] value)
        {
            foreach (byte b in value)
            {
                WriteByte(stream, b);
            }
        }

        #region Read file
        internal static string ReadString(FileStream stream)
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
        internal static Color ReadColor(FileStream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, 4);
            return Color.FromArgb(buffer[0], buffer[1], buffer[2], buffer[3]);
        }
        internal static long ReadLong(FileStream stream)
        {
            int sizeOfLong = sizeof(long);
            byte[] buffer = new byte[sizeOfLong];
            stream.Read(buffer, 0, sizeOfLong);

            return BitConverter.ToInt64(buffer, 0);
        }
        internal static int ReadInt(FileStream stream)
        {
            int sizeOfInt = sizeof(int);
            byte[] buffer = new byte[sizeOfInt];
            stream.Read(buffer, 0, sizeOfInt);

            return BitConverter.ToInt32(buffer, 0);
        }
        internal static byte ReadByte(FileStream stream)
        {
            return (byte)stream.ReadByte();
        }
        internal static byte[] ReadBytes(FileStream stream)
        {
            byte[] ret = new byte[stream.Length];
            stream.Read(ret, 0, ret.Length);
            return ret;
        }
        #endregion
    }
}
