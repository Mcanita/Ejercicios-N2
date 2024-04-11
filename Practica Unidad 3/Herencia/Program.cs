using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Tester t1 = new Tester();

            Console.WriteLine("ingrese el nombre : ");
            p1.Nombre = Console.ReadLine();
            Console.WriteLine("ingrese el nombre del tester: ");
            t1.Nombre = Console.ReadLine();

            Console.WriteLine("el nombre ingresado es " + p1.Nombre);
            Console.WriteLine("el nombre ingresado para el tester es  " + t1.Nombre);
            Console.ReadKey();

        }
    }
}
