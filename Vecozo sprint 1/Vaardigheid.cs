﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecozo_sprint_1
{
    public class Vaardigheid
    {
        private string VaardigheidNaam;

        public Vaardigheid(string naam)
        {
            this.VaardigheidNaam = naam;
        }
        public override string ToString()
        {
            return VaardigheidNaam;
        }
    }
}
