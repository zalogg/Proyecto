 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige una de las opciones");
            Console.WriteLine("1) Serie de Fibonacci");
            Console.WriteLine("2) Factorial de un Numero");
            Console.WriteLine("3) Salir");
            
            int otp = int.Parse(Console.ReadLine());

            switch (otp)
            {
                case 1:
                    Console.WriteLine("Has elegido la Opción 1 Serie de Fibonacci");
                    int can;
                    int a, b, c;
                    Console.WriteLine("Digite el valor de N: ");
                    can = int.Parse(Console.ReadLine());
                    a = 0; b = 1;
                    Console.Write(a + "," + b + ",");
                    for (int k = 3; k <= can; k++)
                    {
                        c = a + b;
                    Console.Write(c + ",");
                    //intercambio de valores
                    a = b;
                    b = c;
                    }
                    break;
               case 2:
                    Console.WriteLine("Has elegido la Opción 2 Factorial de un Numero ");
                    Console.WriteLine("Ingrese el número: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int factorial = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine("El factorial de "+num+" es "+factorial);
                    Console.ReadLine();
                    break;
               case 3:
                    break;
                default:
                    Console.WriteLine("Debe elegir una opció correcta");
                    break;
            }
            
            Console.ReadKey();


            }
    }
}
