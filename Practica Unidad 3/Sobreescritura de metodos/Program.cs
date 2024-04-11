using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            AnimalDomestico dome1 = new AnimalDomestico();
            dome1.Nombre = "toto";
            Perro p1 = new Perro();
            Console.WriteLine(a1.ToString());
            //muestra en pantalla "la definicion del objeto"

            Console.WriteLine(dome1.ToString());
            Console.WriteLine("");

            Console.WriteLine(dome1.comunicarse());
            Console.WriteLine(p1.comunicarse());

            // puedo asignar un perro dentro de un animal ya que perro ES un animal 
            // a1 = p1;
            //NO puedo asignar a un animal dentro de un pero xq no se si ese animal ES un perro
            // p1 = a1;
            //PARA QUE NO SALTE ERROR SE UTILIZA EL casteo explícito
            // p1 = (Perro)a1;   así le digo al compilador que A1 es un Perro y que lo trate como tal.


            // CREO UNA LISTA DE ANIMALES
            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(dome1);
            animales.Add(a1);
            animales.Add(new AnimalDomestico());
            animales.Add(new Perro());
            Console.WriteLine("");


            //recorro la lista y hago que cada animal se comunique como sabe comunicarse
            foreach(Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

           

            Console.ReadKey();
        }
    }
}
