using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce la ruta del archivo");
            String ruta = Console.ReadLine();
            StreamReader sr = new StreamReader(ruta);
            Console.WriteLine("introduce la palabra");
            String palabra = Console.ReadLine();
            String a;
            int cont = 0;
            while ((a = sr.ReadLine()) != null)
            {
                if (a.Contains(palabra)) { 
                    cont++;
                }
            }
            sr.Close();
            Console.WriteLine("Hay " + cont + " ocurrencias de la palabra "+palabra);

        }
    }
}
