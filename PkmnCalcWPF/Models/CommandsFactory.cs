// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnCalcWPF/blob/master/LICENSE for license details.

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
