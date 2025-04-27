using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        // Persona: edad, Sueldo, Nombre
        // Atributos o Miembros
        private int edad;
        private float sueldo;
        private string nombre; // string en minúscula, es propio de C# para el uso de cadena

       public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        //Método Setter
        public void setEdad(int e)
        {
            this.edad = e;
        }

        public int getEdad()
        {
            return this.edad;
        }

        // Métodos --> tienen que ser más bien comportamientos relacionados con la clase...
        // deben ser "public"

        public string saludar()
        {
            return "hola soy... " + nombre;
        }

        // Método sobrecargado 
        public string saludar(string personaje)
        {
            return "Hola " + personaje + " soy... " + nombre;
        }
    }
}
