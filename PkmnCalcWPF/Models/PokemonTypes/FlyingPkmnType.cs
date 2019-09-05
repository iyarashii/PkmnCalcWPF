﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class FlyingPkmnType : IPkmnType
    {
        public string TypeName => "FLYING";

        public double DmgTaken { get; set; }

        public string TypeColor => "#A890F0";
    }
}
