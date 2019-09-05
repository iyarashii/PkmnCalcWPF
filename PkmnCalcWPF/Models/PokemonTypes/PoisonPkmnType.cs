﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class PoisonPkmnType : IPkmnType
    {
        public string TypeName => "POISON";

        public double DmgTaken { get; set; }

        public string TypeColor => "#A040A0";
    }
}