using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    class Auto : Vehiculo
    {
        //Constructor 
        public Auto()
        {

        }

        //Propiedades
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //Composición (con lo que nace si o si )
        public Chasis Chasis { get; }

        //Agregación (algo que se puede agregar despues )
        public Motor Motor { get; set; }











    }
}
