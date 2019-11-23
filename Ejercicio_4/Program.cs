using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palabras = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce un numero: ");
                String palabra = Console.ReadLine();

                palabras.Add(palabra);
            }

            palabras.Sort();

            foreach (string list_numeros in palabras)
            {
                Console.WriteLine(list_numeros);
            }
        }
    }
}
