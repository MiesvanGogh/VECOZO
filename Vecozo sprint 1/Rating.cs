using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecozo_sprint_1
{
    public class Rating
    {
        private string RatingNaam;

        public Rating(string naam)
        {
            this.RatingNaam = naam;
        }
        public override string ToString()
        {
            return RatingNaam;
        }
    }
}
