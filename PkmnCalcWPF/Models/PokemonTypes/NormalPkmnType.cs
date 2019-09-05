using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class NormalPkmnType : IPkmnType
    {
        public string TypeName => "NORMAL";

        public double DmgTaken { get; set; }

        public string TypeColor => "#A8A878";
    }
}
