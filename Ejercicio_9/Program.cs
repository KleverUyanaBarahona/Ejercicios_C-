using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz_1 = new Matriz();
            Matriz matriz_2 = new Matriz();
            matriz_1.EscribirMatriz();
            matriz_2.EscribirMatriz();
            matriz_1.Suma(matriz_2);
            matriz_1.EscribirMatriz();
        }
    }
}
