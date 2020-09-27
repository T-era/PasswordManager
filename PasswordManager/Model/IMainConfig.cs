using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Model
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using PasswordManager.Master.Listup;

    public interface IMainConfig : INotifyPropertyChanged, PasswordManagerLib.IMainConfig
    {
        BindingSource Items { get; }
    }
}
