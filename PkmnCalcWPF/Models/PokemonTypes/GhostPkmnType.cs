using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class GhostPkmnType : PkmnType
    {
        public override string TypeName => "GHOST";

        public override string TypeColor => "#705898";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is GhostPkmnType || pkmnType is PsychicPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is DarkPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is NormalPkmnType)
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
