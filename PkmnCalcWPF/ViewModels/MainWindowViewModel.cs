using PkmnCalcWPF.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PkmnCalcWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        // view binding properties
        public IPkmnType SelectedPrimaryType { get; set; }
        public IPkmnType SelectedSecondaryType { get; set; }
        public bool IsDamageTakenGridVisible { get; set; } = false;
        
        // collection of all pokemon types
        public ObservableCollection<IPkmnType> PkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();

        // command that shows damage taken by selected pokemon type combination after the button is clicked
        public ICommand ShowDamageTakenCommand { get; set; }

        // constructor
        public MainWindowViewModel()
        {
            ShowDamageTakenCommand = CommandsFactory.CreateShowDamageTakenCommand(this);
        }
    }
}
