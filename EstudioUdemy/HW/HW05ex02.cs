using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW05ex02
    {
        public static void Main()
        {
            Console.WriteLine("—————————Metodos—————————");
            Console.WriteLine("1. Hallar área de un círculo.");
            Console.WriteLine("2. Hallar área de un cuadrado.");
            Console.WriteLine("3. Hallar área de un tríangulo.");
            Console.Write("\nEscoja que desea hacer: ");
            string n = Console.ReadLine();
            
            switch (n)
            {
                case "1":
                    ACir();
                    break;
                case "2":
                    ACua();
                    break;
                case "3":
                    ATri();
                    break;
                default:
                    Console.WriteLine("Opción invalida.");
                    break;
            }
        }
        static void ACir()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Introduzca radio del círculo: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del círculo de radio {0} es {1}", r, Math.PI * r * r);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nADVERTENCIA - Excepción detectada: \n{0} \nEl formato correcto es 00.0\nPresiona Enter y vuelve a intentarlo.", e.Message);
                    Console.ReadLine();
                }
            }
        }
        static void ACua()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Introduzca radio del cuadrado: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del cuadrado de lado {0} es {1}", l, l*l);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nADVERTENCIA - Excepción detectada: \n{0} \nEl formato correcto es 00.0\nPresiona Enter y vuelve a intentarlo.", e.Message);
                    Console.ReadKey();
                }
            }
        }
        static void ATri()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Introduzca la base del tríangulo: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Introduzca la altura del tríangulo: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del tríangulo de base {0} y altura {1} es {2}", b, h, 0.5*b*h);
                    break;
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
