using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.Drawing;

    public interface IMainConfig
    {
        event Action PasswordConfirmed;

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

        void SaveToFile();
    }
}
