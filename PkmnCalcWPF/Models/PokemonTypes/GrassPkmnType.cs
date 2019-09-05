using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class GrassPkmnType : IPkmnType
    {
        public string TypeName => "GRASS";

        public double DmgTaken { get; set; }

        public string TypeColor => "#78C850";
    }
}
