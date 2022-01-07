using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu = Udemy.Menu;
using static Udemy.HWList;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializo una referencia a la clase Menu
            Menu menu = new Menu();
            HWList h = new HWList();

            // Bandera de ejecución
            bool run = true;
            bool hw_run = true;

            // Seleccion de opciones
            string hw, ex;

            while (run)
            {
                menu.PrintM("0");
                hw = menu.Option();

                if (hw != "0")
                {
                    while (hw_run)
                    {
                        menu.PrintM(hw);
                        ex = menu.Option();

                        if (ex != "0")
                        {
                            Console.Clear();
                            h.GetHW(hw, ex);
                        }
                        else
                        { hw_run = false;}
                    }
                    hw_run = true;
                }
                else
                { run = false; }
            }
        }
    }
}