using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW02ex02
    {
        public static void Main()
        {
            double c;
            while (true)
            {
                try
                {
                    Console.Write("Introduzca un valor en grados Celsius: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n {0} ºC son: {1} ºF", c, (c * 9 / 5) + 32);
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
