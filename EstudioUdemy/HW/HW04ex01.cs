using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW04ex01
    {
        public static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Introduzca un número: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Introduzca una potencia: ");
                    int exp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Math.Pow(n, exp));
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
