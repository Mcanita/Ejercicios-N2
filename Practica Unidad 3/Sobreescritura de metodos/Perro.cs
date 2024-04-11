using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    class Perro : AnimalDomestico
    {

        public override string comunicarse()
        {
            return "Gua Gua ... ";

        }
    }
}
