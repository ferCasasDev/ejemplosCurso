using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Animal
    {
       
        // que el método sea "VIRTUAL" me permite a mi poder overridearlo  
        public virtual string Comunicarse()
        {
            return "ruido ... ruido...";
        }
    }
}
