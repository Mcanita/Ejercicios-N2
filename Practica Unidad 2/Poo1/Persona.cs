using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    class Persona
    {
        //Persona : edad, sueldo, nombre
        private int edad;
        private float sueldo;
        private string nombre;


        public Persona(string nombre)
        {
            this.nombre = nombre;
        }


        //accedo a los atributos por medio de funciones 
        public void setEdad (int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }


        // MÉTODO

        public string saludar()
        {
            return "HOLA SOY ... " + nombre;
        }

        public string saludar(string personaje)
        {
            return "hola "+ personaje + " soy ..." + nombre;

        }





    }
}
