using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          Primer Lote con 10 registros de producto, cada prpoducto tiene:
            //          - Código de artículo (3 dígitos no correlativos)
            //          - Precio
            //          - Código de Marca (1 a 10)
            //          Segundo Lote con las ventas de la semana. Cada venta tiene:
            //          - Código de artículo
            //          - Cantidad
            //          - Código de cliente (1 a 100)
            //          Este lote corta con código de Cliente cero (0)

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Ingrese Código de Artículo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Código de Marca (1 a 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            // cargado el vector completo..
            // se trabaja ahora con el ciclo de proceso...

            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Ingrese Código de CLiente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            
            while ()
            {
                Console.WriteLine("Código de Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // trabajamos...

                // pido cliente nuevamente...
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Ingrese Código de CLiente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
