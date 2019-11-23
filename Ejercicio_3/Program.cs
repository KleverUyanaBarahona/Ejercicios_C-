using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce un numero: ");
                String numLetra = Console.ReadLine();
                int num = Convert.ToInt32(numLetra);

                numeros.Add(num);
            }

            numeros.Sort();

            foreach (int list_numeros in numeros)
            {
                Console.WriteLine(list_numeros);
            }
        }
    }
}
