using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int cont = 0;
            StreamWriter sw = new StreamWriter("C:\\Users\\PC\\Desktop\\Colecciones\\fichero.txt");
            for (int i = 1; i <=500; i++) {

                for (int j = i; j>0; j--)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    sw.WriteLine(i);
                }
                cont = 0;
            }
            sw.Close();
        }
    }
}
