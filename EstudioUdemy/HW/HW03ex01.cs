using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW03ex01
    {
        public static void Main()
        {
            Console.Write("Ingrese mes en formato númerico: ");
            string c = Console.ReadLine();

            switch (c)
            {
                case "1":
                    Console.WriteLine("Enero");
                    break;
                case "2":
                    Console.WriteLine("Febrero");
                    break;
                case "3":
                    Console.WriteLine("Marzo");
                    break;
                case "4":
                    Console.WriteLine("Abril");
                    break;
                case "5":
                    Console.WriteLine("Mayo");
                    break;
                case "6":
                    Console.WriteLine("Junio");
                    break;
                case "7":
                    Console.WriteLine("Julio");
                    break;
                case "8":
                    Console.WriteLine("Agosto");
                    break;
                case "9":
                    Console.WriteLine("Septiembre");
                    break;
                case "10":
                    Console.WriteLine("Octubre");
                    break;
                case "11":
                    Console.WriteLine("Noviembre");
                    break;
                case "12":
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Por favor escoje un número entre 1 y 12.");
                    break;
            }
        }
    }
}
