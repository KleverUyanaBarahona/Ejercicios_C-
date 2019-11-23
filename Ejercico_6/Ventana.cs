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
        private int porcentaje;
        public Ventana()
        {

        }
        public void abrir(int porcentajeVentana)
        {

            porcentaje = porcentajeVentana;

            if (porcentajeVentana >= 0 || porcentajeVentana <= 100)
            {
                if (porcentaje == 0)
                {
                    abierto = false;
                    Console.WriteLine("La ventana está cerrada'0%'");
                }
                else if (porcentaje == 100)
                {
                    abierto = true;
                    Console.WriteLine("La ventana está abierta '100%'");
                }
                else
                {
                    Console.WriteLine("La ventana está abierta al " + porcentaje + " %.");
                }
            }
            else
            {
                if (porcentajeVentana > 100)
                {
                    Console.WriteLine("La ventana no se puede abrir mas del 100% .");
                }
                else
                {
                    Console.WriteLine("La ventana no se puede abrir menos del 0% .");
                }

            }
        }

    public void abrir() {
            abierto = true;
        }

        public void cerrar() {
            abierto = false;    
        }
    }
}
