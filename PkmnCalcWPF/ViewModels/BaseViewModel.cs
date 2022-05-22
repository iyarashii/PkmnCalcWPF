// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnCalcWPF/blob/master/LICENSE for license details.

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PkmnCalcWPF.ViewModels
{
    // base class for all viewmodels in this app, implements INotifyPropertyChanged interface and basic view model methods
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}