// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnCalcWPF/blob/master/LICENSE for license details.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonTypeLibrary.Models;

namespace PkmnCalcWPF.ViewModels
{
    // factory class used for instantiating PkmnTypeViewModel objects
    public static class PkmnTypeViewModelFactory
    {
        public static ObservableCollection<IPkmnType> GeneratePkmnTypeList()
        {
            ObservableCollection<IPkmnType> output = new ObservableCollection<IPkmnType>
            {
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateNormalPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateFightingPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateFlyingPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreatePoisonPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateGroundPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateRockPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateBugPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateGhostPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateSteelPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateFirePkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateWaterPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateGrassPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateElectricPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreatePsychicPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateIcePkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateDragonPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateDarkPkmnType()),
                CreatePkmnTypeViewModel(PkmnTypeFactory.CreateFairyPkmnType())
            };
            return output;
        }

        public static ObservableCollection<IPkmnType> PopulateComboboxPkmnTypeList()
        {
            ObservableCollection<IPkmnType> output = GeneratePkmnTypeList();
            output.Insert(0, CreatePkmnTypeViewModel(PkmnTypeFactory.CreateEmptyPkmnType()));

            return output;
        }

        public static IPkmnType CreatePkmnTypeViewModel(IPkmnType pkmnType)
        {
            return new PkmnTypeViewModel(pkmnType);
        }
    }
}
