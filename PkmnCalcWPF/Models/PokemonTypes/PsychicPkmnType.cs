using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class PsychicPkmnType : PkmnType
    {
        public override string TypeName => "PSYCHIC";

        public override string TypeColor => "#F85888";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is FightingPkmnType || pkmnType is PoisonPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is SteelPkmnType || pkmnType is PsychicPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is DarkPkmnType)
            {
                output = 0.0;
            }
            else
            {
                output = 1.0;
            }
            return output;
        }
    }
}
