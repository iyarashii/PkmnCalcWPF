// Copyright (c) 2022 iyarashii @ https://github.com/iyarashii 
// Licensed under the GNU General Public License v3.0,
// go to https://github.com/iyarashii/PkmnCalcWPF/blob/master/LICENSE for license details.

using PokemonTypeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmnCalcWPF.ViewModels
{
    // wrapper for PkmnType model
    public class PkmnTypeViewModel : BaseViewModel, IPkmnType
    {
        public PkmnTypeViewModel(IPkmnType pkmnType)
        {
            PokemonType = pkmnType;
        }

        public IPkmnType PokemonType { get; set; }
        public string TypeName { get => PokemonType.TypeName; }

        public double DmgMultiplier { get; set; }

        public string TypeColor { get => PokemonType.TypeColor; }

        public double CalculateDmgMultiplier(IPkmnType defendingPkmnPrimaryType, IPkmnType defendingPkmnSecondaryType)
        {
            return PokemonType.CalculateDmgMultiplier(defendingPkmnPrimaryType, defendingPkmnSecondaryType);
        }
    }
}
