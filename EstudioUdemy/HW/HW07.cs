using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class HW07
    {
        public static void Main()
        {
            string nombre, apellidos, direccion, rfc;
            double saldo, monto;
            byte opcion=1;

            #region MenuInicial
            Console.Clear();
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.WriteLine("║                 Banco Udemy                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════╝\n");
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese sus apellidos: ");
            apellidos = Console.ReadLine();
            Console.Write("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            Console.Write("Ingrese su rfc: ");
            rfc = Console.ReadLine();
            Console.Write("Ingrese su saldo inicial: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            #endregion

            // Creo referencia a la clase CuentaBancaria pasando los campos
            CuentaBancaria usuario = new CuentaBancaria(nombre, apellidos, saldo, direccion, rfc);
            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║               Menú               ║");
                Console.WriteLine("╚══════════════════════════════════╝\n");
                Console.WriteLine("1. Depósito.");
                Console.WriteLine("2. Retiro.");
                Console.WriteLine("3. Consultar Saldo.");
                Console.WriteLine("4. Mostrar información de cuenta");
                Console.WriteLine("5. Salir\n");
                Console.Write(">> ");
                try
                {
                    opcion = Convert.ToByte(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Sistema de Depósitos.\n");
                            Console.Write("Ingrese monto a depositar: ");
                            monto = Convert.ToDouble(Console.ReadLine());
                            usuario.Deposito(monto);
                            Console.WriteLine("Depósito realizado con éxito.");
                            Console.Write("\n\nPresione Enter para regresar...");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Sistema de Retiros.\n");
                            Console.Write("Ingrese monto a retirar: ");
                            monto = Convert.ToDouble(Console.ReadLine());
                            usuario.Retiro(monto);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Sistema de Consulta de Saldos.\n");
                            usuario.ConsultaSaldo();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Información de la Cuenta.\n");
                            Console.WriteLine(usuario.ToString());
                            Console.Write("\n\nPresione Enter para regresar...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nADVERTENCIA - Excepción detectada: \n{0} \nEl formato correcto es 00\nPresiona Enter y vuelve a intentarlo.", e.Message);
                    Console.ReadKey();
                }

            }
            while (opcion >= 1 && opcion <= 4);

        }

    }

    class CuentaBancaria
    {
        // Campos de la clase
        private string nombre, apellidos, direccion, rfc;
        private double saldo;

        // Constructor
        public CuentaBancaria (string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string rfcPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            rfc = rfcPa;
        }

        // Metodos
        public double Deposito(double montoPa)
        {
            saldo += montoPa;
            return saldo;
        }
        public double Retiro(double montoPa)
        {
            if (saldo > 0)
            {
                saldo -= montoPa;
                Console.WriteLine("El retiro fue procesado con éxito.");
                Console.Write("\n\nPresione Enter para regresar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El retiro no puede ser efectuado.");
                Console.Write("\n\nPresione Enter para regresar...");
                Console.ReadKey();
            }
            return saldo;
        }
        public void ConsultaSaldo()
        {
            Console.WriteLine(saldo);
            Console.ReadKey();
        }
        public override string ToString()
        {
            return nombre + " " + apellidos + " " + direccion + " " + rfc + " " + saldo;
        }
    }
}
