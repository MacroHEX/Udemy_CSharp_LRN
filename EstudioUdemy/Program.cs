using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu = Udemy.Menu;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            bool ejecutando = true;

            while (ejecutando)
            {
                menu.PrintM();
                Console.ReadKey();
            }
        }
    }
}