using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }


        //sobreescrivo el método ToString para que me devuelva el nnombre (siempre va public override )
        public override string ToString()
        {
            return "animal : " + Nombre;
        }


    }
}
