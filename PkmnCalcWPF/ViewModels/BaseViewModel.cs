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