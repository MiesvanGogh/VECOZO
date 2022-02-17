using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecozo_sprint_1
{
    public class Rol
    {

        private string RolNaam;

        public Rol(string naam)
        {
            this.RolNaam = naam;
        }
        public override string ToString()
        {
            return RolNaam;
        }
    }
}
