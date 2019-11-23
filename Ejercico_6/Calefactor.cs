using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Calefactor : Casa
    {
        private int temperatura;
        private Boolean encendido;
        public Calefactor()
        {
            this.temperatura = 25;
        }

        public void encender() {
            encendido = true;
        }

        public void apagar() {
            encendido = false;
        }

        public void fijarTemperatura(int temperaturaDeseada) {
            temperatura = temperaturaDeseada;
        }

    }
}
