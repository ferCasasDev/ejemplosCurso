using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona("Pepe");
            //Persona p2 = new Persona("Helena");
            //Persona p3 = new Persona("Sara");

            //p1.setEdad(42);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("Ferchu"));
            //Console.WriteLine("la edad es: " + p1.getEdad());

            //p2.setEdad(3);
            //Console.WriteLine(p2.saludar());
            //Console.WriteLine("La edad de Helena es: " + p2.getEdad()); 
            //p3.setEdad(2);
            //Console.WriteLine(p3.saludar());
            //Console.WriteLine("La edad de Sara es: " + p3.getEdad());

            Botella b1 = new Botella("rojo", "plástico"); // la palabra reservada "new" invoca al constructor
            //int algo = b1.Capacidad; // lectura o recuperación mediante Propiedad
            //b1.Capacidad = 200; // asiganción mediante Propiedad

            Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CapacidadActual);

            b1.reacrgar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CapacidadActual);

            b1.reacrgar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CapacidadActual);

            Console.ReadKey();
        }
    }
}
