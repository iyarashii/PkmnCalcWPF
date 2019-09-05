using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class FairyPkmnType : IPkmnType
    {
        public string TypeName => "FAIRY";

        public double DmgTaken { get; set; }

        public string TypeColor => "#FF65D5";
    }
}
