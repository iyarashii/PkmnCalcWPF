using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class FightingPkmnType : IPkmnType
    {
        public string TypeName => "FIGHTING";

        public double DmgTaken { get; set; }

        public string TypeColor => "#C03028";

    }
}
