using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Samuel Hernandez Perez 21210671
namespace Numero_Cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Salida de programa hasta que cumpla.
            bool SalidaE = true;

            //titulo
            Console.Title = "NUMERO AL CUADRADO CON EXCEPCIONES";

            //ciclo
            do
            {
                //Limpiar consola para ingrsar nuevamente
                Console.Clear();

                //inicio de validadcion 
                try
                {
                    //Asiganacion de valor a las variables
                    Console.Write("Ingrese un numero entero: ");
                    int numero = int.Parse(Console.ReadLine());

                    //Calculo
                    Console.WriteLine(numero + "^2 = " + (numero * numero));

                    //Si no es correcta la validacion no permite la salida
                    SalidaE = false;
                }
                //verificacion de error
                catch (FormatException e)
                {
                    //Mensaje de error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.ResetColor();
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Presione enter para continuar. . .");
                Console.ReadKey();

             
            } while (SalidaE == true);
        }
    }
}
