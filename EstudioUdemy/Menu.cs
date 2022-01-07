using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class Menu
    {
        public void PrintM()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║    Menú de Ejercicios Udemy Edition    ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("║  1- Introducción a C# (Impresiones)    ║");
            Console.WriteLine("║  2- Elementos Básicos (Operaciones)    ║");
            Console.WriteLine("║  3- Toma de Decisiones (If)            ║");
            Console.WriteLine("║  4- Los Ciclos (While | For)           ║");
            Console.WriteLine("║  5- Los Métodos (Calculos)             ║");
            Console.WriteLine("║  6- Las Matrices (Matriz de Matrices)  ║");
            Console.WriteLine("║  7- Las Clases (Instancias)            ║");
            Console.WriteLine("║                                        ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.Write("\nEscoja su opción: ");

        }
    }
}
