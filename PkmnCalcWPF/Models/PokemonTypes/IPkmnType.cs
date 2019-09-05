using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public interface IPkmnType
    {
        string TypeName { get; }
        double DmgTaken { get; set; }
        string TypeColor { get; } 
    }
}
