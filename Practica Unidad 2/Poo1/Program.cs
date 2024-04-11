using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona: edad, sueldo, nombre
            Persona p1 = new Persona("JORGE");

            p1.setEdad(20);

            Console.WriteLine(p1.saludar("marta"));
            Console.WriteLine("La edad de la persona es " + p1.getEdad());
            

            Botella b1 = new Botella();
            b1.Capacidad = 1000;

            Console.WriteLine("la capasidad de la botella es de : " + b1.Capacidad);
            Console.ReadKey();


        }
    }
}
