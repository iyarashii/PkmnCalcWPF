using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class PsychicPkmnType : IPkmnType
    {
        public string TypeName => "PSYCHIC";

        public double DmgTaken { get; set; }

        public string TypeColor => "#F85888";
    }
}
