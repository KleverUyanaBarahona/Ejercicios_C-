using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Puerta : Casa
    {
        private Boolean abierto;
       public Puerta()
        {

        }

        public void abrir() {
            abierto = true;
        }

        public void cerrar() {
            abierto = false;
        }
    }
}
