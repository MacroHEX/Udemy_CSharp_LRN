using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW08
    {
        public static void Main()
        {
            bool run = true;


            List<string> clientes_name = new List<string>();
            List<string> clientes_surname = new List<string>();
            List<string> clientes_ci = new List<string>();

            while (run)
            {
                Console.Clear();
                Console.WriteLine("Lista de Clientes del Banco.\n");
                Console.WriteLine("1. Añadir Usuario.");
                Console.WriteLine("2. Eliminar Usuario.");
                Console.WriteLine("3. Listar Usuarios.");
                Console.WriteLine("4. Salir.");
                Console.Write("\n>> ");
                Console.ReadKey();

            }
        }
    }   
}