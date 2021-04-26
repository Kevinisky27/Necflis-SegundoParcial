using System;
using System.IO;

namespace netflis
{
    public class NewCliente
    {
        public void IngresoNewCliente()
        {
            string NombreCliente;
            String Direccion;
            int Edad; 

            // Ingreso del nombre del nuevo cliente
            Console.Write("Nombre: ");
            NombreCliente = Console.ReadLine();

            // Ingreso de la Edad del Usuario
            Console.Write("Edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());


            // Ingreso de la Dirección
            Console.Write("Dirección: ");
            Direccion = Console.ReadLine();



             // Creación de Texto Plano
             TextWriter Escribe = new StreamWriter("Clientes.txt");
             Escribe.WriteLine("Nombre: " + NombreCliente);
             Escribe.WriteLine("Edad: " + Edad);
             Escribe.WriteLine("Dirección: " + Direccion);

             Escribe.Close();

            Console.Write("\n           Cliente ingresado con éxito          \n");

        }

        public void LeerCliente()
        {
            TextReader VerCliente = new StreamReader("Clientes.txt");
            Console.WriteLine("\n" + VerCliente.ReadToEnd());
            VerCliente.Close();
        }

    }
}