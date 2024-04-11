using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_POO_2
{
    class Venta
    {
        // - Código artículo
        // - Cantidad
        // - Código cliente (1 al 100)
        // Este lote corta con Código de cliente cero
        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }

    }
}
