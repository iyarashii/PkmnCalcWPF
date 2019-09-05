﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PkmnCalcWPF.Models
{
    public class SteelPkmnType : IPkmnType
    {
        public string TypeName => "STEEL";

        public double DmgTaken { get; set; }

        public string TypeColor => "#B8B8D0";
    }
}