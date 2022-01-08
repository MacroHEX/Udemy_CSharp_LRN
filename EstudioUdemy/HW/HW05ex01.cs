using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW05ex01
    {
        public static void Main()
        {
            Console.WriteLine("El valor en radianes es {0}.", Conversion());
        }

        static double Conversion()
        {
            while (true)
            {
                try
                {
                    Console.Write("Introduzca un valor (en grados) a convertir: ");
                    return (Convert.ToDouble(Console.ReadLine())) * Math.PI / 180;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nADVERTENCIA - Excepción detectada: \n{0} \nEl formato correcto es 00.0\nPresiona Enter y vuelve a intentarlo.", e.Message);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
