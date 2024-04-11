using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("MODELO1", "SAMSUNG");
            Console.WriteLine("el modelo es : " + t1.Modelo);
            Console.WriteLine(t1.Llamar("Marcelo"));
            Console.WriteLine(t1.Llamar());
            Console.ReadKey();


        }
    }
}
