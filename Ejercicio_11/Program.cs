using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\PC\\Desktop\\Colecciones\\fichero.txt");
            String a;
            while ((a = sr.ReadLine())!=null) {
                Console.WriteLine(a);
            }
            sr.Close();
        }
    }
}
