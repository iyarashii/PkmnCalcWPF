﻿using PkmnCalcWPF.ViewModels;
using PokemonTypeLibrary.Models;

namespace PkmnCalcWPF.Models
{
    // command that shows damage taken by selected pokemon type combination after the button is clicked
    public class ShowDamageTakenCommand : RelayCommand
    {
        private static MainWindowViewModel viewModel;

        // constructor takes view model instance as parameter
        public ShowDamageTakenCommand(MainWindowViewModel vm) : base(() => ExecuteShowDamageTakenCommand())
        {
            viewModel = vm;
        }

        // executes CalculateDmgMultiplier method on each member of PkmnTypeList collection
        public static void ExecuteShowDamageTakenCommand()
        {
            // check if some type is selected if not hide the DataGrid
            if(viewModel.SelectedPrimaryType is EmptyPkmnType && viewModel.SelectedSecondaryType is EmptyPkmnType)
            {
                viewModel.IsDamageTakenGridVisible = false;
                return;
            }

            foreach (var pkmnType in viewModel.PkmnTypeList)
            {
                pkmnType.DmgMultiplier = pkmnType.CalculateDmgMultiplier(viewModel.SelectedPrimaryType, viewModel.SelectedSecondaryType);
            }

            viewModel.IsDamageTakenGridVisible = true;
        }
    }
}
