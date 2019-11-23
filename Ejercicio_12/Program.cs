using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce la ruta del archivo");
            String ruta = Console.ReadLine();

            StreamReader sr = new StreamReader(ruta);
            
           
            List<String> palabras = new List<string>();
            String a;
            while ((a = sr.ReadLine()) != null)
            {
                palabras.Add(a);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(ruta.Replace(".txt", "_sort.txt"));
            palabras.Sort();
            foreach (String p in palabras) {
                sw.WriteLine(p);
            }
            sw.Close();
        }
    }
}
