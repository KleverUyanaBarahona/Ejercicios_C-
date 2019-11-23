using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    public class Gato : Animal
    {
        public Gato()
        {
            Console.WriteLine("Ha nacido un gato.");
        }

        public  void comunicar()
        {
            Console.WriteLine("Miauuu");
        }
    }
}
