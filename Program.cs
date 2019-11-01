using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia la clase operaciones ya que es la que tiene todos los metodos, debido a que se le heredo 
            //principal

            Operacion M = new Operacion();
            M.Bienvenida();
        }
    }
}
