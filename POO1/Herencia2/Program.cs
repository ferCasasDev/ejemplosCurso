using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehiculo > Auto > AutoDeportivo > AutoUrbano
            // Camioneta
            // Moto

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "Roja";
            c1.CargaMaxima = 3000;
            c2.Color = "Verde";
            c2.CargaMaxima = 2500;
            c3.Color = "Azul";
            c3.CargaMaxima = 1500;

            // defino la lista 
            List<Camioneta> listaCamionetas = new List<Camioneta>();

            // añadir elementos
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);
            
            Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count); // conteo
            c2.Color = "Blanco"; // puedo cambiar y me mostrará el nuevo valor porque está referenciado 

            Console.WriteLine("El color es: " + listaCamionetas[1].Color); // una en particular con su propiedad
            Console.WriteLine("La capacidad de carga es: " + listaCamionetas[1].CargaMaxima);

            listaCamionetas.Remove(c3);

            Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count); // Elimina
            Console.WriteLine("");
            // Leer todos los Objetos de la lista
            // Recorrer la lista con "for each"

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
                Console.WriteLine("Capacidad de carga: " + item.CargaMaxima);
            }
           
            Console.ReadKey();

        }
    }
}
