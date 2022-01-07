using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW06
    {
        public static void Main(string n)
        {
            double[][] clases;
            clases = Carga();
            switch (n)
            {
                case "1":
                    Promedio(clases);
                    break;
                case "2":
                    Menor(clases);
                    break;
                case "3":
                    Mayor(clases);
                    break;
                case "4":
                    Impresion(clases);
                    break;
            }
        }

        static double[][] Carga()
        {
            // Creo las variables
            byte i, j, a, b;
            double[][] clases;

            // Pido el total de las clases
            Console.Write("Introduzca Nº. de clases: ");
            a = Convert.ToByte(Console.ReadLine());

            // Creo e inicializo la matriz de matrices de las clases y la de alumnos
            clases = new double[a][];

            for (i = 0; i < clases.Length; i++)
            {
                // Creo las matrices de los alumnos por clase
                Console.Write("Introduzca Nº. de alumnos en la clase {0}: ", i + 1);
                b = Convert.ToByte(Console.ReadLine());

                // Creo e inicializo la matriz de matrices de las alumnos
                clases[i] = new double[b];
            }

            // Ciclo de carga de notas
            for (i = 0; i < clases.Length; i++)
            {
                for (j = 0; j < clases[i].Length; j++)
                {
                    // Cargo las notas de cada alumno
                    Console.Write("Introduzca el promedio del alumno {0} de la clase {1}: ", j + 1, i + 1);
                    clases[i][j] = Convert.ToByte(Console.ReadLine());
                }
            }
            return clases;
        }

        static void Impresion(double[][] clases)
        {
            // Variables para ciclo for
            byte i, j;
            // Impresion
            for (i = 0; i < clases.Length; i++)
            {
                for (j = 0; j < clases[i].Length; j++)
                {
                    Console.Write(clases[i][j]);
                }
                Console.WriteLine("");
            }
            Promedio(clases);
            Menor(clases);
            Mayor(clases);
        }

        static void Promedio(double[][] clases)
        {
            // Variables para ciclo for
            byte i, j;
            double total, promedio;

            for (i = 0; i < clases.Length; i++)
            {
                total = 0;
                for (j = 0; j < clases[i].Length; j++)
                {
                    total += clases[i][j];
                }
                promedio = total / clases[i].Length;
                Console.WriteLine("El promedio de la clase {0} es {1}", i + 1, promedio);
            }
        }

        static void Menor(double[][] clases)
        {
            // Variables para ciclo for
            byte i, j;

            for (i = 0; i < clases.Length; i++)
            {
                double min = clases[i][0];
                for (j = 0; j < clases[i].Length; j++)
                {
                    if (min > clases[i][j])
                    {
                        min = clases[i][j];
                    }
                }
                Console.WriteLine("El puntaje menor de la clase {0} es {1}", i + 1, min);
            }
        }
        static void Mayor(double[][] clases)
        {
            // Variables para ciclo for
            byte i, j;

            for (i = 0; i < clases.Length; i++)
            {
                double max = clases[i][0];
                for (j = 0; j < clases[i].Length; j++)
                {
                    if (max < clases[i][j])
                    {
                        max = clases[i][j];
                    }
                }
                Console.WriteLine("El puntaje mayor de la clase {0} es {1}", i + 1, max);
            }
        }
    }
}
