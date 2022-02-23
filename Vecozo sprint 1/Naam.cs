using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecozo_sprint_1
{
    public class Naam
    {
        private string NaamNaam;

        public Naam(string naam)
        {
            this.NaamNaam = naam;
        }
        public override string ToString()
        {
            return NaamNaam;
        }
    }
}
