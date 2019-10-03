using PkmnCalcWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmnCalcWPF.ViewModels
{
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
