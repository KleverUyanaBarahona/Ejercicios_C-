using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    public class Perro : Animal
    {
        public Perro()
        {
            Console.WriteLine("Ha nacido un perro.");
        }

        public void comunicar()
        {
            Console.WriteLine("Guau");
        }
    }
}
