using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro a1 = new Perro();
            a1.comunicar();
        
            Gato a2 = new Gato();
            a2.comunicar();
     

            GatoSiames a3 = new GatoSiames();
            a3.comunicar();
            

        }
    }
}
