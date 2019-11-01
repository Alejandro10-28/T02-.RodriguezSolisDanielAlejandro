using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1._2
{
  public class Principal
    {
        //Se instancia operacion ya que es la que contiene los metodos con los que vamos a trabajar
        Operacion operacion;
        //Se usa la bienvenida que es con la que trabajara el usuario

        public void Bienvenida()
        {
            Console.WriteLine("====BIENVENIDO A CALCULADORA======");
            Console.WriteLine(">>TU CALCULADORA FAVORITA ONLINE:");
            Menu();

        }
        //Se utiliza el menu para que el usuario pueda seleccionar la opcion que desee
        public void Menu()
        {
            operacion = new Operacion();
            Console.WriteLine("Escoge la operacion que deseas realizar:");
            Console.WriteLine("\n1-.Sumar\n2-.Restar\n3-.Dividir\n4-.multiplicar");
            switch (Console.ReadLine())
            {
                case "1":

                    ObtenerDato();
                   double R= operacion.Sumar(operacion.Numero1,operacion.Numero2);
                    Console.WriteLine("El resultado es:" + R);
                    Console.ReadKey();
                    break;
                case "2":
                    ObtenerDato();
                    double R1 = operacion.Restar(operacion.Numero1, operacion.Numero2);


                    Console.WriteLine("El resultado es:" + R1);
                    Console.ReadKey();
                    break;
                case "3":
                    ObtenerDato();
                    double R2 = operacion.Dividir(operacion.Numero1, operacion.Numero2);


                    Console.WriteLine("El resultado es:" + R2);
                    Console.ReadKey();


                    break;
                case "4":
                    ObtenerDato();
                    double R3 = operacion.Multiplicar(operacion.Numero1, operacion.Numero2);


                    Console.WriteLine("El resultado es:" + R3);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.Clear();
            Bienvenida();
        }
        //Se hace el metodo para poder obtener los datos que ingrese el usuario
        public void ObtenerDato()
        {
            Console.WriteLine("Ingresa valor 1 :");
          operacion.  Numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa valor 2 :");
          operacion.  Numero2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
