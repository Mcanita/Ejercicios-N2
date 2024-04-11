using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_POO_2
{
    class Articulo
    {
        // - Código Artículo (3 dígitos no correlativos)
        // - Precio
        // - Código de marca (1 a 10)

        //otra forma de acceder a los atributos es omitiendo la creacion de la variable privada
        //y construir directamente la propiedad : 

        // private int codArticulo;
        //se escribe "prop" + tab + tab 
        public int CodigoArticulo { get; set; }


        // private float precio;
        public float Precio { get; set; }

        private int codMarca;


        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
            
    }
}
