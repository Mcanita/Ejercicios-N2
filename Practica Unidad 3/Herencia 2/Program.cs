using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //Camioneta 
            //Moto

            Vehiculo v1 = new Vehiculo();
            AutoDeportivo ad1 = new AutoDeportivo();

            Console.WriteLine("ingrese el modelo del motor del vehiculo: ");
            v1.Motor = Console.ReadLine();
            Console.WriteLine("ingrese el modelo del motor auto deportivo : ");
            ad1.Motor = Console.ReadLine();
            ad1.Pasajeros = 4;

            Console.WriteLine("el motor del auto es : " + ad1.Motor);
            Console.WriteLine("el motor del vehiculo es : " + v1.Motor);
            Console.WriteLine("el auto tiene capacidad para : "+ ad1.Pasajeros +" pasajeros");
            Console.ReadKey();
        }
    }
}
