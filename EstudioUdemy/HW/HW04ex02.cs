using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW04ex02
    {
        public static void Main()
        {
            int divisores = 0;
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 1)
                {
                    Console.WriteLine("{0} es primo", i);
                }
                divisores = 0;
            }
        }
    }
}
