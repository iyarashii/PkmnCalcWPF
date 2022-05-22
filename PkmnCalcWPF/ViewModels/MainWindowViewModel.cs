// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnCalcWPF/blob/master/LICENSE for license details.

using PkmnCalcWPF.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PokemonTypeLibrary.Models;
using System.Linq;

namespace PkmnCalcWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        // view binding properties
        public IPkmnType SelectedPrimaryType { get; set; } = PkmnTypeViewModelFactory.CreatePkmnTypeViewModel(PkmnTypeFactory.CreateEmptyPkmnType());
        public IPkmnType SelectedSecondaryType { get; set; } = PkmnTypeViewModelFactory.CreatePkmnTypeViewModel(PkmnTypeFactory.CreateEmptyPkmnType());
        public bool IsDamageTakenGridVisible { get; set; } = false;
        public IPkmnType SavedSelectedPrimaryType { get; set; }
        public IPkmnType SavedSelectedSecondaryType { get; set; }
        public int SavedPrimaryIndex { get; set; }
        public int SavedSecondaryIndex { get; set; }

        // collection of all pokemon types
        public ObservableCollection<IPkmnType> PkmnTypeList { get; set; } = PkmnTypeViewModelFactory.GeneratePkmnTypeList();
        public ObservableCollection<IPkmnType> PrimaryTypePkmnTypeList { get; set; } = PkmnTypeViewModelFactory.PopulateComboboxPkmnTypeList();
        public ObservableCollection<IPkmnType> SecondaryTypePkmnTypeList { get; set; } = PkmnTypeViewModelFactory.PopulateComboboxPkmnTypeList();

        // command that shows damage taken by selected pokemon type combination after the button is clicked
        public ICommand ShowDamageTakenCommand { get; set; }

        // constructor
        public MainWindowViewModel()
        {
            ShowDamageTakenCommand = CommandsFactory.CreateShowDamageTakenCommand(this);
        }

        // TODO: cleanup
        // event handler called on DropDownClosed event for primary type combobox
        public void OnPrimaryTypeSelected()
        {
            if(SavedSelectedSecondaryType != null)
            {
                SecondaryTypePkmnTypeList.Insert(SavedSecondaryIndex, SavedSelectedSecondaryType);
            }

            if (!(SelectedPrimaryType is EmptyPkmnType))
            {
                SavedSelectedSecondaryType = SecondaryTypePkmnTypeList.Where(i => i.TypeName == SelectedPrimaryType.TypeName).FirstOrDefault();
                SavedSecondaryIndex = SecondaryTypePkmnTypeList.IndexOf(SavedSelectedSecondaryType);
                SecondaryTypePkmnTypeList.Remove(SecondaryTypePkmnTypeList.Where(i => i.TypeName == SelectedPrimaryType.TypeName).FirstOrDefault());
            }

        }
        // TODO: cleanup code
        // event handler called on DropDownClosed event for secondary type combobox
        public void OnSecondaryTypeSelected()
        {
            if (SavedSelectedPrimaryType != null)
            {
                PrimaryTypePkmnTypeList.Insert(SavedPrimaryIndex, SavedSelectedPrimaryType);
            }

            if (!(SelectedSecondaryType is EmptyPkmnType))
            {
                SavedSelectedPrimaryType = PrimaryTypePkmnTypeList.Where(i => i.TypeName == SelectedSecondaryType.TypeName).FirstOrDefault();
                SavedPrimaryIndex = PrimaryTypePkmnTypeList.IndexOf(SavedSelectedPrimaryType);
                PrimaryTypePkmnTypeList.Remove(PrimaryTypePkmnTypeList.Where(i => i.TypeName == SelectedSecondaryType.TypeName).FirstOrDefault());
            }

        }
    }
}
