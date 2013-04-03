using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.ComponentModel;
    using System.IO;

    public class ItemPolicy : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal readonly static char[] CHARS_SIGNS = new [] {
            ' ', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/',
            ':', ';', '<', '=', '>', '?', '@','[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'
        };
        internal readonly static char[] CHARS_NUMBERS = new [] {
            '0', '1', '2','3','4','5','6','7','8','9',
        };
        internal readonly static char[] CHARS_LOWER = new [] {
            'a', 'b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        };
        internal readonly static char[] CHARS_UPPER = new[] {
            'A', 'B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
        };
        internal readonly static IList<char> CHARS_ALL;
        static ItemPolicy()
        {
            CHARS_ALL = new List<char>();
            foreach (char[] mass in new[] { CHARS_NUMBERS, CHARS_LOWER, CHARS_UPPER, CHARS_SIGNS })
            {
                foreach (char c in mass)
                {
                    CHARS_ALL.Add(c);
                }
            }
        }
        private readonly string name;
        private IList<char> usableChars;
        private string password;

        private string location;
        private LocationType locationType;
        public string Location
        {
            set
            {
                if (!string.Equals(location, value))
                {
                    location = value;
                    PropertyChangedEvent("Location");
                }
            }
            get { return location; }
        }
        public LocationType LocationType {
            set
            {
                if (locationType != value)
                {
                    locationType = value;
                    PropertyChangedEvent("LocationType");
                }
            }
            get { return locationType; }
        }

        public string Name { get { return name; } }

        private DateTime? limit;
        private string remarks;
        private Terms termUnit;
        private int term;
        private bool lengthWidth;
        private int minLength;
        private int maxLength;
        private bool allowNumber;
        private bool allowAlphabet;
        private bool allowSign;

        public DateTime? Limit
        {
            set
            {
                bool hasChange;
                if (limit == null && value == null) hasChange = false;
                else if (limit == null) hasChange = true;
                else if (value == null) hasChange = true;
                else hasChange = ! DateTime.Equals(limit.Value, value.Value);

                if (hasChange)
                {
                    limit = value;
                    PropertyChangedEvent("Limit");
                }
            }
            get { return limit; }
        }
        public string Remarks
        {
            set
            {
                if (!string.Equals(remarks, value))
                {
                    remarks = value;
                    PropertyChangedEvent("Remarks");
                }
            }
            get { return remarks; }
        }
        public Terms TermUnit
        {
            set
            {
                if (termUnit != value)
                {
                    termUnit = value;
                    PropertyChangedEvent("TermUnit");
                }
            }
            get { return termUnit; }
        }
        public int Term
        {
            set
            {
                if (term != value)
                {
                    term = value;
                    PropertyChangedEvent("Term");
                }
            }
            get { return term; }
        }
        public int MinLength
        {
            set
            {
                if (minLength != value)
                {
                    minLength = value;
                    PropertyChangedEvent("MinLength");
                }
            }
            get { return minLength; }
        }
        public int MaxLength
        {
            set
            {
                if (maxLength != value)
                {
                    maxLength = value;
                    PropertyChangedEvent("MaxLength");
                }
            }
            get { return maxLength; }
        }
        public bool LengthWidth
        {
            set
            {
                if (lengthWidth != value)
                {
                    lengthWidth = value;
                    PropertyChangedEvent("LengthWidth");
                }
            }
            get { return lengthWidth; }
        }
        public bool AllowNumber {
            set
            {
                if (allowNumber != value)
                {
                    allowNumber = value;
                    PropertyChangedEvent("AllowNumber");
                }
            }
            get { return allowNumber; }
        }
        public bool AllowAlphabet
        {
            set
            {
                if (allowAlphabet != value)
                {
                    allowAlphabet = value;
                    PropertyChangedEvent("AllowAlphabet");
                }
            }
            get { return allowAlphabet; }
        }
        public bool AllowSign {
            set
            {
                if (allowSign != value)
                {
                    allowSign = value;
                    PropertyChangedEvent("AllowSign");
                }
            }
            get { return allowSign; }
        }

        public string Password { get { return password; } }

        internal IList<char> UsableChars { get { return usableChars; } }

        public IEnumerator<char> GetUsableChars()
        {
            foreach (char c in usableChars)
            {
                yield return c;
            }
        }

        private ItemPolicy(string name)
        {
            this.name = name;
        }

        public static ItemPolicy CreateNewItem(string name)
        {
            return new ItemPolicy(name)
            {
                AllowNumber = true,
                AllowAlphabet = true,
                AllowSign = true,
                usableChars = CHARS_ALL,
                TermUnit = Terms.月,
                Term = 6,
                LengthWidth = true,
                MinLength = 8,
                MaxLength = 16,
                Remarks = string.Empty,
            };
        }

        public static ItemPolicy LoadFromFile(string path)
        {
            FileInfo file = new FileInfo(path);

            using (var input = file.OpenRead())
            {
                string location = FileIo.ReadString(input);
                LocationType locationType = (LocationType)FileIo.ReadByte(input);
                long limitSeed = FileIo.ReadLong(input);

                DateTime? limit;
                if (limitSeed == 0)
                {
                    limit = null;
                }
                else
                {
                    limit = new DateTime(limitSeed);
                }
                Terms termUnit = (Terms)FileIo.ReadByte(input);
                int term = FileIo.ReadInt(input);
                int minLength = FileIo.ReadInt(input);
                int maxLength = FileIo.ReadInt(input);
                string charset = FileIo.ReadString(input);

                byte allow = FileIo.ReadByte(input);
                bool allowNumber = allow % 2 == 1;
                bool allowAlphabet = (allow >> 1) % 2 == 1;
                bool allowSign = (allow >> 2) % 2 == 1;
                string remarks = FileIo.ReadString(input);

                return new ItemPolicy(file.Directory.Name)
                {
                    Location = location,
                    LocationType = locationType,
                    Limit = limit,
                    TermUnit = termUnit,
                    Term = term,
                    MinLength = minLength,
                    MaxLength = maxLength,
                    LengthWidth = minLength != maxLength,
                    AllowNumber = allowNumber,
                    AllowAlphabet = allowAlphabet,
                    AllowSign = allowSign,
                    usableChars = charset.ToList(),
                    Remarks = remarks,
                };
            }
        }
        public void SaveToFile(string datFolder)
        {
            using (var output = MakeFileIfNotExists(datFolder, Name, "policy"))
            {
                FileIo.WriteUtf8Bytes(output, Location);
                FileIo.WriteByte(output, (byte)LocationType);
                FileIo.WriteLong(output, Limit == null ? 0 : Limit.Value.Ticks);
                FileIo.WriteByte(output, (byte)TermUnit);
                FileIo.WriteInt(output, Term);
                FileIo.WriteInt(output, MinLength);
                FileIo.WriteInt(output, MaxLength);
                FileIo.WriteUtf8Bytes(output, new string(usableChars.ToArray()));

                byte allow = (byte)((AllowSign ? 4 : 0) + (AllowAlphabet ? 2 : 0) + (AllowNumber ? 1 : 0));
                FileIo.WriteByte(output, allow);
                FileIo.WriteUtf8Bytes(output, Remarks);
            }
        }
        public void SavePassword(string newPassword, string masterPass, string datFolder)
        {
            password = newPassword;
            PropertyChangedEvent("Password");
            using (var output = MakeFileIfNotExists(datFolder, Name, "password"))
            {
                FileIo.WriteBytes(output, PasswordFactory.ToCrypto(newPassword, masterPass));
                output.Flush();
                output.Close();

            }
        }
        public void ResavePassword(string oldMasterPass, string newMasterPass, string datFolder)
        {
            if (string.IsNullOrEmpty(password))
            {
                ReadPassword(oldMasterPass, datFolder);
            }
            using (var output = MakeFileIfNotExists(datFolder, Name, "password"))
            {
                FileIo.WriteBytes(output, PasswordFactory.ToCrypto(password, newMasterPass));
                output.Flush();
                output.Close();
            }
        }
        public void ReadPassword(string masterPass, string datFolder)
        {
            using (var input = File.OpenRead(datFolder + "\\" + Name + "\\password"))
            {
                password = PasswordFactory.FromCrypto(FileIo.ReadBytes(input), masterPass);
                PropertyChangedEvent("Password");
            }
        }

        private static FileStream MakeFileIfNotExists(string folder, string itemName, string fileName)
        {
            string fullPath = folder + "\\" + itemName + "\\" + fileName;
            if (File.Exists(fullPath))
            {
                BackupFile(fullPath);
            }
            return File.Create(fullPath);
        }
        private static void BackupFile(string originPath)
        {
            FileInfo file = new FileInfo(originPath);
            FileInfo dest = new FileInfo(file.DirectoryName + "\\_" + file.Name);
            if (dest.Exists)
            {
                BackupFile(dest.FullName);
            }
            File.Move(file.FullName, dest.FullName);
        }
        internal void AddAllUsableChars(char[] chars)
        {
            foreach (char c in chars)
            {
                usableChars.Add(c);
            }
        }
        internal void RemoveAllUsableChars(char[] chars)
        {
            foreach (char c in chars)
            {
                usableChars.Remove(c);
            }
        }
        internal TimeSpan LimitSpan()
        {
            switch (TermUnit)
            {
                case Terms.年:
                    return new TimeSpan(365 * Term, 0, 0, 0);
                case Terms.月:
                    return new TimeSpan(30 * Term, 0, 0, 0);
                case Terms.週:
                    return new TimeSpan(7 * Term, 0, 0, 0);
                default:
                    throw new Exception();
            }
        }
        internal bool HasPasswordFile(string datFolder)
        {
            return File.Exists(datFolder + "\\" + Name + "\\password");
        }
        private void PropertyChangedEvent(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum Terms : byte
    {
        週 = 1,
        月 = 2,
        年 = 3,
    }
    public enum LocationType : byte
    {
        URL = 1,
        その他 = 2,
    }
}
