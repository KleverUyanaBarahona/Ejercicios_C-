using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Persiana : Ventana
    {
        private Boolean subida;
        public Persiana()
        {

        }
        public void subir() {
            subida = true;
        }

        public void bajar() {
            subida = false;
        }
    }
}
