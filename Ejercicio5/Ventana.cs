using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Ventana : Casa
    {
        private Boolean abierto;
        public Ventana()
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
