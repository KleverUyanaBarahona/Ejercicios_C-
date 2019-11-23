using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clases
{
    class Gato
    {
        
        public Gato()
        {
            numero++;
        }
        public static int numero = 0;
    }

    class Main
    {
        public static void main(String [] args)
        {
            Gato a, b, c, d;

            a = new Gato();
            b = new Gato();
            c = new Gato();
            d = new Gato();

            /*
            Console.WriteLine(a.numero);
            Console.WriteLine(b.numero);
            Console.WriteLine(c.numero);
            Console.WriteLine(d.numero);
            */
        }
    }
}
