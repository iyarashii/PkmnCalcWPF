using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class GroundPkmnType : IPkmnType
    {
        public string TypeName => "GROUND";

        public double DmgTaken { get; set; }

        public string TypeColor => "#E0C068";
    }
}
