using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecozo_sprint_1
{
    public class Persoonlijkheden
    {
        private string PersoonlijkhedenNaam;

        public Persoonlijkheden(string naam)
        {
            this.PersoonlijkhedenNaam = naam;
        }
        public override string ToString()
        {
            return PersoonlijkhedenNaam;
        }
    }
}
