using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class IcePkmnType : IPkmnType
    {
        public string TypeName => "ICE";

        public double DmgTaken { get; set; }

        public string TypeColor => "#98D8D8";
    }
}
