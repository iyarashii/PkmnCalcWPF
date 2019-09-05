using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class DarkPkmnType : IPkmnType
    {
        public string TypeName => "DARK";

        public double DmgTaken { get; set; }

        public string TypeColor => "#705848";
    }
}
