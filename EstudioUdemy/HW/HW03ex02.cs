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
            Console.Write("Introduzca un número: ");
            string n = Console.ReadLine();
            int divisores = 0;

            for (int i = 1; i <= Convert.ToInt32(n); i++)
            {
                if (Convert.ToInt32(n) % i == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2)
            {
                Console.WriteLine("{0} es primo", n);
            }
        }
    }
}

