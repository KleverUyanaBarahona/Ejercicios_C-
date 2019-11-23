using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Matriz
    {
        private int[,] matriz;
        public Matriz(){
            for(int i=0;i<3;i++) 
            {
                for (int j = 0; j < 3; j++) {
                    this.addValor(i,j);
                }
            }
        }
        private void addValor(int i, int j) {
            Console.WriteLine("introcuce el valor");
            String sVal = Console.ReadLine();
            int val = Convert.ToInt32(sVal);
            this.matriz[i, j] = val;
            
        }
        private int leerValor(int i, int j)
        {
            int val = this.matriz[i, j];
            return val;
        }
        public void EscribirMatriz()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(this.leerValor(i,j));
                }
                Console.WriteLine("");
            }
        }
        public void Suma(Matriz m) {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.matriz[i, j] = this.leerValor(i,j) + m.leerValor(i,j);
                }
            }
            this.EscribirMatriz();
        }


    }
}
