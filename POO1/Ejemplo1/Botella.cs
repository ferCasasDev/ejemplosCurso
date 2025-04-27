using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        // Constructor -> al principio de la clase.
        //                mismo nombre que la clase
        //                puede o no contener argumentos
        
        // El Constructor es un método que nos permite colocar valores iniciales


        //*******************************************************
        // Algunos ajustes...
        // Capacidad máxima: comienza en 100
        // Cantidad Actual: comienza en 0
        // método de recarga: caraga al 100 y devuelve el costo de recargar. 50 cada 100

        public Botella (string color, string material) 
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        // Sobrecargar el Constructor
        // Se utiliza el mismo constructor, pero cambia la firma. Los argumentos deben ser
        // totalmente distintos
        public Botella() { }
        


        // Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad 
        {
            get { return capacidad; }
        }

        public int CapacidadActual
        {
            get { return cantidadActual;}
        }

        public string Material // Propiedad Read Only
        {
            get { return material; }
        }

        //Propiedad --> es como maneja C# en vez de los setters y getters...
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //Métodos
        public float reacrgar ()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100;
                // cargo la botella al 100%
                cantidadActual += dif;
                // retorno el monto de la carga.
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float reacrgar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }


    }
}
