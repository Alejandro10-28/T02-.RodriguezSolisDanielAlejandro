using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1._2
{
    //Se crea la interfaz , cabe destacar que una interfaz ya es publica por eso no necesita el "public"
    interface IOperacion 
    {
        //Se encapsulan las variables normalmente
        double Numero1 { get; set; }
        double Numero2 { get; set; }
        //Los metodos se crean pero no se inician aqui sino en la clase donde se vayan a utilizar.
        double Sumar(double N1, double N2);
        double Restar(double N1, double N2);
        double Dividir(double N1,double N2);
        double Multiplicar(double N1,double N2);

    }
}
