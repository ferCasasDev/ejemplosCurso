using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "Pepo";

            Perro p1 = new Perro();
            p1.Nombre = "Pipo";


            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());
            animales.Add(new Gato());
            animales.Add(new Perro());

            List<IFlyable> listaVoladores = new List<IFlyable>(); // instancio una Lista de tipo IFlyable
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.Comunicarse()); // cada cual se cominucará como sabe hacerlo...
            }

            foreach (IFlyable item in listaVoladores)
            {
                Console.WriteLine(item.volar());
            }

            // Polimorfismo: característica que tienen los objetos de, frente a un mismo estímulo,
            // comportarse de manera distinta...


            //Animal a1 = g1; // a1 contiente un gato adentro...
            //Gato g8 = (Gato)a1; // "Casteo explícito" Yo sé y le aseguro que adenrto hay un gato...
            //Console.WriteLine(g8.Nombre);


            Console.ReadKey();


        }
    }
}
