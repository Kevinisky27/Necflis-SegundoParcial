using System;
using System.IO;

namespace netflis
{
    public struct NecflisPlayList
    {
        public void NewPelicula()
        { 
            int OP1; 

            Console.WriteLine("1. Ingreso de Serie");
            Console.WriteLine("2. Ingreso de Película");
            OP1 = Convert.ToInt16(Console.ReadLine());

            // valuación de las operaciones Serie / Película
            switch (OP1)
            {
                // Ingreso de una Nueva Serie
                case 1:

                    string Serie;
                    string SinopsisSerie;

                    int OpGe; 

                    Console.WriteLine("Bienvenido a la opción Serie");

                    Console.Write("Nombre de la Serie: ");
                    Serie = Console.ReadLine();

                    Console.WriteLine("\nOperaciones, para género de serie: ");
                    
                    Console.WriteLine("1. Drama" + "\n2. Comedia" + "\n3. Terror" + "\n4. Suspenso");
                    Console.Write("Digite una opción: ");
                    OpGe =Convert.ToInt16(Console.ReadLine());

                    switch (OpGe)
                    {
                        case 1:
                            Console.WriteLine("Categoría de Drama Agregado con éxito.");
                            break;

                        case 2:
                            Console.WriteLine("Categoría de Comedia Agregado con éxito.");
                            break;

                        case 3:
                            Console.WriteLine("Categoría de Terror agregado con éxito");
                            break;

                        case 4:
                            Console.WriteLine("Categoría de Suspenso Agregado con éxito");
                            break;
                        
                    }

                    Console.WriteLine("Escribe el resumen de la serie: ");
                    SinopsisSerie = Console.ReadLine();

                    // Creación de Texto Plano
                    TextWriter Escribe = new StreamWriter("Serie.txt");
                    Escribe.WriteLine("Serie: " + Serie);
                    Escribe.WriteLine("Resumen: " + SinopsisSerie);
                    Escribe.WriteLine("Género: " + OpGe);
                    Escribe.WriteLine("1. Drama" + "2. Comedia" + "3. Terror" + "4. Suspenso");

                    Escribe.Close();

                    Console.Write("     Serie ingresada con éxito     ");

                    break;



                    // Ingreso de una Nueva Película
                case 2:

                    string Peli2;
                    string SinopsisPeli;

                    int OpGe2;

                    Console.WriteLine("Bienvenido a la opción Película");

                    Console.Write("Nombre de la Película: ");
                    Peli2 = Console.ReadLine();

                    Console.WriteLine("\nOperaciones, para género de película: ");

                    Console.WriteLine("1. Drama" + "\n2. Comedia" + "\n3. Terror" + "\n4. Suspenso");
                    Console.Write("Digite una opción: ");
                    OpGe2 = Convert.ToInt16(Console.ReadLine());

                    switch (OpGe2)
                    {
                        case 1:
                            Console.WriteLine("Categoría de Drama Agregado con éxito.");
                            break;

                        case 2:
                            Console.WriteLine("Categoría de Comedia Agregado con éxito.");
                            break;

                        case 3:
                            Console.WriteLine("Categoría de Terror agregado con éxito");
                            break;

                        case 4:
                            Console.WriteLine("Categoría de Suspenso Agregado con éxito");
                            break;

                    }

                    Console.WriteLine("Escribe el resumen de la película: ");
                    SinopsisPeli = Console.ReadLine();

                    // Creación de Texto Plano
                    TextWriter EscribePeli = new StreamWriter("Películas.txt");
                    EscribePeli.WriteLine("Película: " + Peli2);
                    EscribePeli.WriteLine("Resumen: " + SinopsisPeli);
                    EscribePeli.WriteLine("Género: " + OpGe2);
                    EscribePeli.WriteLine("1. Drama, 2. Comedia, 3. Terror, 4. Suspenso");
                    EscribePeli.Close();

                    Console.Write("     Película Ingresada con éxito     ");
                    break;
            }
        }


        public void LeerArchivoSerie()
        {

            TextReader LeerSerie = new StreamReader("Serie.txt");
            Console.WriteLine("\n" + LeerSerie.ReadToEnd());
            LeerSerie.Close();

        }

        public void LeerArchivoPeli()
        {
            TextReader LeerSerie = new StreamReader("Películas.txt");
            Console.WriteLine("\n" + LeerSerie.ReadToEnd());
            LeerSerie.Close();
        }
    }
}
