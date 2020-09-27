using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManagerLib
{
    using System.ComponentModel;
    using System.Drawing;

    public interface IMainConfig : INotifyPropertyChanged
    {
        event Action PasswordConfirmed;
        event Action PasswordLocked;
        event Action ItemModified;

        string ConfName { get; }
        Color HideFore { set; get; }
        Color HideBack { set; get; }
        Color ShowFore { set; get; }
        Color ShowBack { set; get; }
        string DatFolder { set; get; }
        string Remarks { set; get; }

        byte[] HashedPass { set; get; }
        bool IsPasswordConfirmed { get; }
        string Password { set; get; }

        void AddItem(ItemPolicy item);
        IEnumerator<ItemPolicy> GetItems();
        void SaveToFile();
        byte[] GetSalt();
    }
}
