using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class ElectricPkmnType : IPkmnType
    {
        public string TypeName => "ELECTRIC";

        public double DmgTaken { get; set; }

        public string TypeColor => "#F8D030";
    }
}
