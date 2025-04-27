using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Canario : AnimalDomestico, IFlyable
    {
        // dentro de la clase, definimos el método que la interface nos demanda
        // lo hacemos en cada clase y de forma particular según el requerimiento que necesitemos.-
        
        public string volar()
        {
           return "vuela como un canario...";
        }
    }
}
