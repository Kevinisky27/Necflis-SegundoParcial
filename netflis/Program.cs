using System;

namespace netflis
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op1;
            int Op2;
            int Op3;
            int Op4;
            do
            {
                Console.WriteLine("          Necflis          ");
                //Creamos el menú Principal
                Console.WriteLine(
                "\n1- Clientes" +
                "\n2- Películas" +
                "\n3- Salir");
                Console.Write("Elige entre las siguientes opciones: ");
                Op1 = Convert.ToInt16(Console.ReadLine());

                switch (Op1)
                {

                    case 1:
                        do
                        {
                            Console.WriteLine(
                            "\n1- Ver listado Cliente" +
                            "\n2- Crear Nuevo Cliente" +
                            "\n3- Seleccionar Cliente" +
                            "\n4- Atrás");
                            Console.Write("Elige entre las siguientes opciones: ");
                            Op2 = Convert.ToInt16(Console.ReadLine());


                            switch (Op2)
                            {

                                case 1:
                                    // Lógica para vizualizar los Clientes existentes
                                    NewCliente NuevoCliente = new NewCliente();
                                    NuevoCliente.LeerCliente();

                                    break;
                                    
                                case 2:
                                    do
                                    {
                                        // Lógica para Ingresar un Nuevo Cliente
                                        NewCliente ClienteNuevo = new NewCliente();
                                        ClienteNuevo.IngresoNewCliente();
                                        

                                        Console.WriteLine("\nSi deseas ejecutar nuevamente alguna de las opciones anteriores escribe 1 ");
                                        Op2 = Convert.ToInt16(Console.ReadLine());
                                    } while (Op2 == 1);

                                    break;
                                    

                                case 3:

                                    do
                                    {
                                        Console.WriteLine(
                                        "\n1- PlayList" +
                                        "\n2- Agregar Película" +
                                        "\n3- Atrás");
                                        Console.WriteLine("Elige entre las siguientes opciones: ");
                                        Op3 = Convert.ToInt16(Console.ReadLine());


                                        switch (Op3)
                                        {
                                            case 1:
                                                Console.WriteLine("Bienvenido a las opcion PlayList");
                                                break;

                                            case 2:
                                                Console.WriteLine("Bienvenido a las opcion Agregar Pelicula");
                                                break;

                                            case 3:
                                                Console.WriteLine("Presiona Enter para volver atrás");
                                                Console.ReadKey();
                                                break;

                                        }
                                        Console.WriteLine("Si deseas ejecutar nuevamente alguna de las opciones anteriores escribe 1 ");

                                        Op3 = Convert.ToInt16(Console.ReadLine());
                                    } while (Op3 == 1);
                                    break;


                                case 4:
                                    Console.WriteLine("Presiona Enter para volver atrás");
                                    Console.ReadKey();
                                    break;
                            }
                            Console.Clear();
                            Op2 = Convert.ToInt16(Console.ReadLine());
                        } while (Op2 == 1);
                        break;


                    case 2:
                        Console.WriteLine("Bienvenido a las opcion seleccionar cliente");
                        do
                        {
                            Console.WriteLine(
                            "\n1- Ver listado de Peliculas" +
                            "\n2- Crear Pelicula" +
                            "\n3- Atrás");
                            Console.WriteLine("Elige entre las siguientes opciones: ");
                            Op4 = Convert.ToInt16(Console.ReadLine());


                            switch (Op4)
                            {
                                case 1:
                                    int OpRepo;
                                    Console.WriteLine("Bienvenido a las opcion ver listado de Peliculas");

                                    Console.WriteLine("1- Series \n2- Películas");
                                    OpRepo = Convert.ToInt16(Console.ReadLine());

                                    if (OpRepo == 1)
                                    {
                                        NecflisPlayList Leer_Peliculas = new NecflisPlayList();
                                        Leer_Peliculas.LeerArchivoSerie();
                                 
                                    }
                                    if (OpRepo == 2)
                                    {
                                        NecflisPlayList Leer_Peliculas = new NecflisPlayList();
                                        Leer_Peliculas.LeerArchivoPeli();
                                    }
                                    


                                    break;

                                case 2:
                                    Console.WriteLine("Bienvenido a las opcion Crear Pelicula");

                                    Console.WriteLine("");

                                    NecflisPlayList NuevaSelecion = new NecflisPlayList();
                                    NuevaSelecion.NewPelicula();
                                    break;

                                case 3:
                                    Console.WriteLine("Presiona Enter para volver atrás");
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Esa opcion no existe");
                                    Console.ReadKey();
                                    break;
                            }
                            Console.WriteLine("Si deseas ejecutar nuevamente alguna de las opciones anteriores escribe 1 ");
                            Op4 = Convert.ToInt16(Console.ReadLine());
                        } while (Op4 == 1);
                        break;


                    case 3:
                        Console.WriteLine("Gracias por confiar en nosotros, fue un gusto atenderle. ");
                        Console.WriteLine("     Presione enter para salir     ");
                        break;


                    default:
                        Console.WriteLine("Esa opcion no existe");
                        Console.ReadKey();
                        break;
                }
                //Console.Clear();
                //Console.WriteLine("Si estas seguro de salir responde con un 1 ");
                //Op1 = Convert.ToInt16(Console.ReadLine());


            } while (Op1 == 1);
            {
                Console.ReadKey();
            }
        }
    }
}
           