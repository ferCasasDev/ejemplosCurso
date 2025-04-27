using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal interface IFlyable
    {
        // Interface es como un contrato que define qué métodos se deben utilizar
        // define el QUÉ, mas NO el cómo ...
        
        // defino el método que quiero que sea implementado
        // solo lo escribimos, no lo desarrollamos.
        string volar();
    }
}
