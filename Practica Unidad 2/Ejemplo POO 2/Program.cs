using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_POO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Primer lote con 10 registros de productos, cada producto tiene:
            // - Código Artículo (3 dígitos no correlativos)
            // - Precio
            // - Código de marca (1 a 10)
            // Segundo lote con las ventas de la semana. Cada venta tiene :
            // - Código artículo
            // - Cantidad
            // - Código cliente (1 al 100)
            // Este lote corta con Código de cliente cero

            Articulo articulo1 = new Articulo();
            articulo1.CodigoArticulo = 20;
            articulo1.CodigoMarca = 123;
            Console.WriteLine("el código de marca es : " + articulo1.CodigoMarca);

            //creacion de un vector de 10 artículos
            Articulo[] articulos = new Articulo[5];
            for(int i =0; i<5; i++)
            {
                Console.WriteLine("Ingrese los datos del producto : ");
                Console.WriteLine("Código : ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio : ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 al 10) : ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());

            }
            Venta venta = new Venta();

            Console.WriteLine("ingrese la venta) : ");
            Console.WriteLine("ingrese el codigo de cliente : ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while(venta.CodigoCliente !=0)
            {
                Console.WriteLine("código artículo : ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad : ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos

                //pido cliente nuevamente
                Console.WriteLine("ingrese la venta) : ");
                Console.WriteLine("ingrese el codigo de cliente : ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }



            Console.ReadKey();
        }
    }
}
