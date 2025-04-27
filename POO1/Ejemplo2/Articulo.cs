
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        // Código de artículo(3 dígitos no correlativos)
        // Precio
        // Código de Marca (1 a 10)

        // puedo crear la propiedad en version "reducida" con -> "prop + tab + tab"
        // para ello omitimos la variable privada [nameVar]...

        // es Public la propiedad
        public int CodigoArticulo { get; set; } // es la propiedad... aunque no puedo más que
                                                // setter o getter... no puedo hacer nada más
                                                // para ello como por ejemplo una validación 
                                                // se utiliza la forma larga o completa
        public float Precio { get; set; }

        private int codigoMarca;
        public int CodigoMarca
        {
            get { return codigoMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codigoMarca = value;
                else 
                    codigoMarca = -1;  // cómo si fuera el código de error
            }
        }

    }
}
