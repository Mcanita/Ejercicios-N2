using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro();
            Gato g1 = new Gato();
            Canario c1 = new Canario();


            //lista de animales mezclados
            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(c1);
            animales.Add(g1);
            animales.Add(new Alcon());


            //realizo una lista usando la interfaz, solo puedo agregar animales que puedan volar
            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(c1);
            listaVoladores.Add(new Alcon());

            foreach  (Flyable item  in listaVoladores)
            {
                Console.WriteLine(item.volar());
            }

            Console.ReadKey();
        }
    }
}
