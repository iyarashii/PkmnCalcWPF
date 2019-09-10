﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class NormalPkmnType : PkmnType
    {
        public override string TypeName => "NORMAL";

        public override string TypeColor => "#A8A878";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            
            if (pkmnType is RockPkmnType || pkmnType is SteelPkmnType)
            {
                output = 0.5;
            }
            else if (pkmnType is GhostPkmnType)
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
