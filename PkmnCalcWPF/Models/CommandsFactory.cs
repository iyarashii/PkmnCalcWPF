using PkmnCalcWPF.ViewModels;
using System.Windows.Input;

namespace PkmnCalcWPF.Models
{
    // factory class used for instantiating Command objects
    public static class CommandsFactory
    {
        public static ICommand CreateShowDamageTakenCommand(MainWindowViewModel viewModel)
        {
            return new ShowDamageTakenCommand(viewModel);
        }
    }
}
