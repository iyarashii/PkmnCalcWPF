﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class FightingPkmnType : PkmnType
    {
        public override string TypeName => "FIGHTING";

        public override string TypeColor => "#C03028";

        public override double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType)
        {
            double output;
            if (pkmnType is NormalPkmnType || pkmnType is RockPkmnType || pkmnType is SteelPkmnType || pkmnType is IcePkmnType || pkmnType is DarkPkmnType)
            {
                output = 2.0;
            }
            else if (pkmnType is FlyingPkmnType || pkmnType is PoisonPkmnType || pkmnType is BugPkmnType || pkmnType is PsychicPkmnType || pkmnType is FairyPkmnType)
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
