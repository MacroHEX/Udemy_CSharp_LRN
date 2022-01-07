using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW02ex01
    {
        public static void Main()
        {
            double s;
            int n;
            while (true)
            {
                try
                {
                    Console.Write("Ingrese tamaño del lados: ");
                    s = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException) { Console.WriteLine("\nFormato inválido, reintente."); }
            }
            while (true)
            {
                try
                {
                    Console.Write("Ingrese número de lados: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) { Console.WriteLine("\nFormato inválido, utilice números enteros."); }
            }
            Console.WriteLine("El perimetro es: {0}", s * Convert.ToDouble(n));
        }
    }
}
