using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Canario : AnimalDomestico, Flyable
    {
    
        public override string comunicarse()
        {
            return "Pio, pio ...";
        }

        public string volar()
        {
           return "vuela como un canario";
        }
    }
}
