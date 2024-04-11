using System;
using System.Collections.Generic; //SE NECESITA ESTA LIBRERÍA PARA USAR COLECCION
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo objetos
            Vehiculo v1 = new Vehiculo();
            Auto a1 = new Auto();
            Auto a2 = new Auto();
            Auto a3 = new Auto();

            //les asigno color 
            a1.Color = "rojo";
            a2.Color = "azul";
            a3.Color = "amarillo";

            //CREO UNA LISTA DE AUTOS
            List<Auto> listaAutos = new List<Auto>();

            //agrego objetos a la lista con .add
            listaAutos.Add(a1);
            listaAutos.Add(a2);
            listaAutos.Add(a3);
            listaAutos.Add(a2);

            //cuento la cantidad de elementos con . count
            Console.WriteLine("la cantidad de autos en la lista es de : " + listaAutos.Count);

            //elijo un elemento de la lista para ver el color 
            Console.WriteLine("el color es : " + listaAutos[3].Color);

            //al modificar un valor de un elemento que se encuentra repetido se modifica en todas las repeticiones
            listaAutos[3].Color = "Negro";
            Console.WriteLine("el nuevo color del elemento 4 es : " + listaAutos[3].Color);
            Console.WriteLine("el color del elemento 2 es : " + listaAutos[1].Color);

            //remuevo un elemento de la lista y pregunto otra vez cuantos elementos tiene
            listaAutos.Remove(a2);
            Console.WriteLine("la lista tiene :  " + listaAutos.Count + " elementos ");
            Console.WriteLine("");

            //recorro toda la coleccion y veo los colores
            foreach (Auto item in listaAutos)
            {
                Console.WriteLine("COLOR : " + item.Color);
            }
            // en esta clase de colecciones se puede repetir elementos 
            Console.ReadKey();
        }
    }
}
