using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3_Constructores
{
    class Botella
    {
        //capacidad maxima 100
        //cantidad actual: inicia en cero
        //método recarga: carga al 100 y devuelve el costo de recarga. 50 cada 100

        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //sobrecarga de constructor 
        public Botella() {}

        //destructor

        ~ Botella()
        {
            //la logica ...
        }


        //Botella : Capacidad, Color, Material

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;


        //PROPIEDAD
        // public int Capacidad
        // {
        //    get { return capacidad; }
        //    set { capacidad = value; }
        // }

        public string Color
        {
            get { return color; }
        }

        public string Material
        {
            get { return material; }
        }

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        // METODO

        public float recargar ()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;

            return 50;   
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            

        }









    }
}
