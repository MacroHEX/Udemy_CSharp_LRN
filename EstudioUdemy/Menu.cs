using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class Menu
    {
        public void PrintM(string n)
        {
            Console.Clear();

            switch (n)
            {
                case "0":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("╔════════════════════════════════════════╗");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("║    Menú de Ejercicios Udemy Edition    ║");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("╠════════════════════════════════════════╣");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("║  1. Introducción a C# (Impresiones)    ║");
                    Console.WriteLine("║  2. Elementos Básicos (Operaciones)    ║");
                    Console.WriteLine("║  3. Toma de Decisiones (If)            ║");
                    Console.WriteLine("║  4. Los Ciclos (While | For)           ║");
                    Console.WriteLine("║  5. Los Métodos (Calculos)             ║");
                    Console.WriteLine("║  6. Las Matrices (Matriz de Matrices)  ║");
                    Console.WriteLine("║  7. Las Clases (Instancias)            ║");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("║  0. Salir                              ║");
                    Console.WriteLine("╚════════════════════════════════════════╝");
                    break;
                case "1":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("╔═════════════════════════════════════════╗");
                    Console.WriteLine("║            Introducción a C#            ║");
                    Console.WriteLine("╠═════════════════════════════════════════╣");
                    Console.WriteLine("║                                         ║");
                    Console.WriteLine("║  1. Imprime tu nombre en la consola.    ║");
                    Console.WriteLine("║  2. Agrega más mensajes a la impresión. ║");
                    Console.WriteLine("║                                         ║");
                    Console.WriteLine("║                                         ║");
                    Console.WriteLine("║  0. Atrás                               ║");
                    Console.WriteLine("╚═════════════════════════════════════════╝");
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔═══════════════════════════════════════════════╗");
                    Console.WriteLine("║               Elementos Básicos               ║");
                    Console.WriteLine("╠═══════════════════════════════════════════════╣");
                    Console.WriteLine("║                                               ║");
                    Console.WriteLine("║  1. Calcular perímetro de cualquier polígono. ║");
                    Console.WriteLine("║  2. Convertir grados ºC a ºF.                 ║");
                    Console.WriteLine("║                                               ║");
                    Console.WriteLine("║                                               ║");
                    Console.WriteLine("║  0. Atrás                                     ║");
                    Console.WriteLine("╚═══════════════════════════════════════════════╝");
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║             Toma de Decisiones           ║");
                    Console.WriteLine("╠══════════════════════════════════════════╣");
                    Console.WriteLine("║                                          ║");
                    Console.WriteLine("║  1. Imprimir mes según número ingresado. ║");
                    Console.WriteLine("║  2. Número Par o Impar.                  ║");
                    Console.WriteLine("║  3. Pago estacionamiento por hora.       ║");
                    Console.WriteLine("║                                          ║");
                    Console.WriteLine("║  0. Atrás                                ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("╔════════════════════════════════════════╗");
                    Console.WriteLine("║               Los Ciclos               ║");
                    Console.WriteLine("╠════════════════════════════════════════╣");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("║  1. Calcular potencia de un número.    ║");
                    Console.WriteLine("║  2. Calcular primeros 100 nros primos. ║");
                    Console.WriteLine("║                                        ║");
                    Console.WriteLine("║  0. Atrás                              ║");
                    Console.WriteLine("╚════════════════════════════════════════╝");
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                       Los Métodos                         ║");
                    Console.WriteLine("╠═══════════════════════════════════════════════════════════╣");
                    Console.WriteLine("║                                                           ║");
                    Console.WriteLine("║  1. Transformar grados a radianes.                        ║");
                    Console.WriteLine("║  2. Calcular el área de un círculo, cuadrado o triangulo. ║");
                    Console.WriteLine("║                                                           ║");
                    Console.WriteLine("║  0. Atrás                                                 ║");
                    Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("╔════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                    Las Matrices                    ║");
                    Console.WriteLine("╠════════════════════════════════════════════════════╣");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine("║  1. Calcular promedio de calificaciones por curso. ║");
                    Console.WriteLine("║  2. Calcular la menor calificación por curso.      ║");
                    Console.WriteLine("║  3. Calcular la mayor calificación por curso.      ║");
                    Console.WriteLine("║  4. Ejecutar programa completo.                    ║");
                    Console.WriteLine("║                                                    ║");
                    Console.WriteLine("║  0. Atrás                                          ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════╝");
                    break;
                case "7":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("╔═════════════════════════════════════════════╗");
                    Console.WriteLine("║                  Las Clases                 ║");
                    Console.WriteLine("╠═════════════════════════════════════════════╣");
                    Console.WriteLine("║                                             ║");
                    Console.WriteLine("║  1. Crea una simulación de cuenta bancaria. ║");
                    Console.WriteLine("║                                             ║");
                    Console.WriteLine("║  0. Atrás                                   ║");
                    Console.WriteLine("╚═════════════════════════════════════════════╝");
                    break;
                default:
                    Console.WriteLine("Opción invalida, ingrese 0 para regresar.");
                    break;
            }
        }
        public string Option()
        {
            Console.Write("\n>> ");
            string op = Console.ReadLine();
            return op;
        }
    }
}