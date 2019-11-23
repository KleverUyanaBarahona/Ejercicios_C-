using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class MiClase
    {
       
        private String nombre;

        public MiClase()
        {
            Console.WriteLine("Me he construido");
        }

        ~MiClase() // destructor
        {
            Console.WriteLine("Me he destruido pa siempre jamas lo juro.");
        }
        
        public void setNombre(String s)
        {
            nombre = s;
        }

        public String getNombre()
        {
            return nombre;
        }

        private String Nombre { get; set; }
    }
}
