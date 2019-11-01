using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1._2
{
    //Se hereda IOperacion para hacer uso de los metodos y atributos de la interfaz 
    public class Operacion :Principal, IOperacion//Se instancia primero la clase base antes que la  interfaz
    {
        public double Numero1 { get ; set; }
        public double Numero2 { get; set; }

        

        public double Dividir(double N1, double N2)
        {
            double R = N1 / N2;
          

            return R;
        }

      

        public double Multiplicar(double N1, double N2)
        {
            double R = N1 * N2;
        
            return R;
        }

     

        public double Restar(double N1, double N2)
        {
            double R = N1 - N2;
      
            return R;
        }

        public double Sumar(double N1, double N2)
        {
          
            double R = N1 + N2;
           

            return R;
        }
    }
}
