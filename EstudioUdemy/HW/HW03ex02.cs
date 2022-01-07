using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW03ex02
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Introduzca un número: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        Console.WriteLine("El número {0} es par.", n);
                    }
                    else
                    {
                        Console.WriteLine("El número {0} es impar.", n);
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nADVERTENCIA - Excepción detectada: \n{0} \nEl formato correcto es 00.0\nPresiona Enter y vuelve a intentarlo.", e.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}

