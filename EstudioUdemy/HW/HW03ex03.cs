using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW03ex03
    {
        public static void Main()
        {
            int time;
            while (true)
            {
                try
                {
                    Console.Write("Introduzca estadía en el estacionamiento (en minutos): ");
                    time = Convert.ToInt32(Console.ReadLine());
                    if (time <= 60)
                    {
                        Console.WriteLine("Debes pagar $5.00.");
                    }
                    else if (time <= 120)
                    {
                        Console.WriteLine("Debes pagar $15.00.");
                    }
                    else
                    {
                        Console.WriteLine("Debes pagar $40.00");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nADVERTENCIA - Excepción detectada: \n{0} \nEl formato correcto es 00\nPresiona Enter y vuelve a intentarlo.", e.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
