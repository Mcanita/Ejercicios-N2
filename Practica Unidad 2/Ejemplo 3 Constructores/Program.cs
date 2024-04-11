using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Rojo", "Plastico");
            Botella b2 = new Botella();

            Console.WriteLine("color : "+ b1.Color +" y su material es : " + b1.Material);
            Console.WriteLine("capacidad botella : " + b1.Capacidad);
            Console.WriteLine("la cantidad actual es : " + b1.CantidadActual);

            b1.recargar(50);
            Console.WriteLine("la nueva cantidad actual es : " + b1.CantidadActual);
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b2.GetHashCode());
        




            Console.ReadKey();
        }
    }
}
