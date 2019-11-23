using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> compañeros = new List<string>();

            compañeros.Add("klever");
            compañeros.Add("santi");


            foreach (String nombres in compañeros)
            {
                Console.WriteLine(nombres);
            }

        }
    }
}