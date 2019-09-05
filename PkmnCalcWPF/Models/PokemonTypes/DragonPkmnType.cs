using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class DragonPkmnType : IPkmnType
    {
        public string TypeName => "DRAGON";

        public double DmgTaken { get; set; }

        public string TypeColor => "#7038F8";
    }
}
