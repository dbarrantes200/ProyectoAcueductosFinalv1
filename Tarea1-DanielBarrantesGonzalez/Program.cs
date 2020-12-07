using System;

namespace Tarea1
{
    class Program
    {
        static Categoria[] categorias = new Categoria[10];
        static int contadorCategoria = 0;
        static Cliente[] clientes = new Cliente[10];
        static int contadorCliente = 0;
        static Funcionario[] funcionarios = new Funcionario[10];
        static int contadorFuncionario = 0;
        static Hidrometro[] hidrometros = new Hidrometro[10];
        static int contadorHidrometro = 0;
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            string respuesta = "s";
            do
            {
                Console.Clear();
                Console.WriteLine("****Acueductos y Alcantarillados La Gota****");
                Console.WriteLine("\r\nSISTEMA DE RECAUDACION Y FACTURACION DE CONSUMO DE AGUA");
                Console.WriteLine("\r\nAhorre agua, no la desperdicie, así evita el pago de facturas cuantiosas. Cierre bien los grifos y llaves");
                Console.WriteLine("\r\nSeleccione una Opcion:");
                Console.WriteLine("\r\n1) Registro de Clientes");
                Console.WriteLine("2) Registro de Funcionarios");
                Console.WriteLine("3) Registro de Hidrometros");
                Console.WriteLine("4) Registro de Categorias de Servicios");
                Console.WriteLine("5) Mostrar Registros ");
                Console.WriteLine("6) Salir");
                Console.Write("\r\nSeleccione una opcion: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        IngresarCliente();
                        return true;
                    case "2":
                        IngresarFuncionario();
                        return true;
                    case "3":
                        IngresarHidrometro();
                        return true;
                    case "4":
                        IngresarCategoria();
                        return true;
                    case "5":
                        Submenu();
                        return true;
                    case "6":
                        Console.WriteLine("\n\nQuiere salir del sistema? S para confirmar");
                        respuesta = Console.ReadLine();
                        if (respuesta.ToLower().Equals("s"))
                        {
                            return false;
                        }
                        else
                            return true;
                    default:
                        return true;

                }

            } while (respuesta.ToLower().Equals("s"));
        }



        // Metodo para capturar la informacion de clientes
        private static void IngresarCliente()
        {

            Console.Clear();

            //  string Nombre = Console.ReadLine();
            string respuesta = "s";
            while (respuesta.ToLower().Equals("s"))

            {
                if (contadorCliente == clientes.Length)
                {
                    return;
                }


                Console.WriteLine("Ingrese Identificacion del Cliente");
                string Identificacion = Console.ReadLine();
                if (ClienteRepetido(Identificacion) != null)
                {
                    Console.WriteLine("El cliente que esta intentando ingresar ya existe");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Ingrese Nombre del Cliente:");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Primer Apellido del Cliente:");
                string PrimerApellido = Console.ReadLine();
                Console.WriteLine("Ingrese Segundo Apellido del Cliente:");
                string SegundoApellido = Console.ReadLine();
                Console.WriteLine("Ingrese Correo Electronico:");
                string CorreoElectronico = Console.ReadLine();
                Console.WriteLine("Ingrese Numero de Celular:");
                string NumeroCelular = Console.ReadLine();
                Console.WriteLine("\n\nQuiere ingresar otro cliente?:s/n");
                respuesta = Console.ReadLine();


                Cliente nuevoCliente = new Cliente(Identificacion, Nombre, PrimerApellido, SegundoApellido);
                nuevoCliente.NumeroCelular = NumeroCelular;
                nuevoCliente.CorreoElectronico = CorreoElectronico;
                clientes[contadorCliente] = nuevoCliente;
                contadorCliente++;
                if (contadorCliente == clientes.Length)
                {
                    Console.WriteLine("Se alcanzo el limite de registros, presione una tecla para continuar");
                    Console.ReadKey();
                    return;
                }
                // Console.ReadKey();

            }
        }


        // Metodo para capturar la informacion de funcionarios
        private static void IngresarFuncionario()
        {

            //Console.Clear();
            string respuesta = "s";
            Console.WriteLine("\r\nSISTEMA DE RECAUDACION Y FACTURACION DE CONSUMO DE AGUA");


            while (respuesta.ToLower().Equals("s"))

            {
                if (contadorFuncionario == funcionarios.Length)
                {
                    return;
                }


                Console.WriteLine("Ingrese Identificacion del Funcionario:");
                string identificacion = Console.ReadLine();
                if (FuncionarioRepetido(identificacion) != null)
                {
                    Console.WriteLine("El funcionario que esta intentando ingresar ya existe");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Ingrese Nombre del Funcionario:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Primer Apellido del Funcionario:");
                string primerApellido = Console.ReadLine();
                Console.WriteLine("Ingrese Segundo Apellido del Funcionario:");
                string segundoApellido = Console.ReadLine();
                Console.WriteLine("\n\nQuiere ingresar otro funcionario?:s/n");
                respuesta = Console.ReadLine();
                Funcionario nuevoFuncionario = new Funcionario(identificacion, nombre, primerApellido, segundoApellido);
                funcionarios[contadorFuncionario] = nuevoFuncionario;
                contadorFuncionario++;
            }
        }
        // Metodo para capturar la informacion de Hidrometros
        private static void IngresarHidrometro()
        {

            //Console.Clear();
            string respuesta = "s";
            Console.WriteLine("\r\nSISTEMA DE RECAUDACION Y FACTURACION DE CONSUMO DE AGUA");


            while (respuesta.ToLower().Equals("s"))

            {
                if (contadorHidrometro == hidrometros.Length)
                {
                    return;
                }


                Console.WriteLine("Ingrese Numero de NIS:");
                string NumeroNis = Console.ReadLine();
                if (NisRepetido(NumeroNis) != null)
                {
                    Console.WriteLine("El numero de NIS que esta intentando ingresar ya existe");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Ingrese Marca de Hidrometro:");
                string Marca = Console.ReadLine();
                Console.WriteLine("Ingrese Numero de Serie:");
                string NumeroSerie = Console.ReadLine();
                Console.WriteLine("Ingrese Numero de Identificacion del Cliente:");
                string Identificacion = Console.ReadLine();
                if (ClienteValido(Identificacion) != null)
                {
                    Console.WriteLine("El cliente que esta intentando ingresar no existe");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Ingrese Numero de Categoria:");
                string Categoria = Console.ReadLine();

                if (CategoriaValida(Categoria) != null)
                {
                    Console.WriteLine("La categoria de servicios que esta intentando ingresar no existe");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("\n\nDesea ingresar otro Hidrometro?:s/n");
                respuesta = Console.ReadLine();
                Hidrometro nuevoHidrometro = new Hidrometro(NumeroNis, Marca, NumeroSerie, Categoria, Identificacion);
                hidrometros[contadorHidrometro] = nuevoHidrometro;
                contadorHidrometro++;
            }
        }

        // Metodo para capturar las categorias

        private static void IngresarCategoria()
        {

            Console.Clear();
            string respuesta = "s";
            Console.WriteLine("\r\nSISTEMA DE RECAUDACION Y FACTURACION DE CONSUMO DE AGUA");

            while (respuesta.ToLower().Equals("s"))

            {
                if (contadorCategoria == categorias.Length)
                {
                    return;
                }

                Console.WriteLine("Ingrese Codigo de Categoria:");
                string categoria = Console.ReadLine();
                if (CategoriaRepetida(categoria) != null)
                {
                    Console.WriteLine("La categoria que esta intentando ingresar ya existe");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Ingrese Descripcion:");
                string descripcion = Console.ReadLine();
                Console.WriteLine("\n\nQuiere ingresar otra Categoria? (s/n): ");
                respuesta = Console.ReadLine();
                Categoria nuevaCategoria = new Categoria(categoria, descripcion);
                categorias[contadorCategoria] = nuevaCategoria;
                contadorCategoria++;
            }
        }
        // Metodo para crear un submenu para imprimir reportes
        private static void Submenu()
        {
            Console.Clear();
            Console.WriteLine("****Acueductos y Alcantarillados La Gota****");
            Console.WriteLine("\nSISTEMA DE RECAUDACION Y FACTURACION DE CONSUMO DE AGUA");
            Console.WriteLine("\nSelecciona una Opcion:");
            Console.WriteLine("\n1) Lista de Clientes");
            Console.WriteLine("2) Lista de Funcionarios");
            Console.WriteLine("3) Lista de Hidrometros");
            Console.WriteLine("4) Lista Categorias de Servicios");
            Console.WriteLine("5) Lista todos los datos");
            Console.WriteLine("6) Regresar al Menu Principal");
            Console.Write("\r\nSeleccione una opcion: ");

            switch (Console.ReadLine())
            {
                // Imprime Lista de Clientes
                case "1":

                    Console.WriteLine("Los datos de clientes son: ");
                    Console.WriteLine("{0}{1,10}{2,10}{3,10}{4,10}{5,8}", "Identificacion", "Nombre", "Primer Apellido", "Segundo Apellido", "Correo Electronico", "Celular");
                    for (int i = 0; i < contadorCliente; i++)
                    {
                        Console.WriteLine(clientes[i]);

                    }
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + clientes);
                    Console.ReadKey();
                    break;

                // Imprime Lista de Funcionarios
                case "2":
                    Console.WriteLine("Lista de Funcionarios: ");
                    for (int i = 0; i < contadorFuncionario; i++)
                    {
                        Console.WriteLine(funcionarios[i]);
                    }
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + funcionarios);
                    Console.ReadKey();
                    break;

                // Imprime Lista de Hidrometros
                case "3":
                    Console.WriteLine("Lista de Hidrometros: ");
                    for (int i = 0; i < contadorHidrometro; i++)
                    {
                        Console.WriteLine(hidrometros[i]);
                    }
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + hidrometros);
                    Console.ReadKey();
                    break;
                // Imprime Lista de Categorias
                case "4":
                    Console.WriteLine("Lista de Categoria de Servicios: ");
                    for (int i = 0; i < contadorCategoria; i++)
                    {
                        Console.WriteLine(categorias[i]);
                    }
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + categorias);
                    Console.ReadKey();
                    break;
                case "5":
                    // Imprime Lista de Clientes
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + clientes);
                    Console.WriteLine("Los datos de clientes son: ");
                    Console.WriteLine("{0}{1,20}{2,10}{3,10}{4,10}{5,8}", "Identificacion", "Nombre", "Primer Apellido", "Segundo Apellido", "Correo Electronico", "Celular");
                    for (int i = 0; i < contadorCliente; i++)
                    {
                        Console.WriteLine(clientes[i]);

                    }
                    // Imprime Lista de Funcionarios
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + funcionarios);
                    Console.WriteLine("Lista de Funcionarios: ");
                    for (int i = 0; i < contadorFuncionario; i++)
                    {
                        Console.WriteLine(funcionarios[i]);
                    }
                    // Imprime Lista de Hidrometros
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + hidrometros);
                    Console.WriteLine("Lista de Hidrometros: ");
                    for (int i = 0; i < contadorHidrometro; i++)
                    {
                        Console.WriteLine(hidrometros[i]);
                    }
                    //Imprime Lista de Categorias de Servicios
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Se esta imprimiendo el arreglo: " + categorias);
                    Console.WriteLine("Lista de Categoria de Servicios: ");
                    for (int i = 0; i < contadorCategoria; i++)
                    {
                        Console.WriteLine(categorias[i]);
                    }
                    Console.ReadKey();
                    break;
                // Regresa al menu principal
                case "6":
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        // Metodo para validar que el cliente sea valido 
        private static Cliente ClienteValido(string identificacion)
        {
            for (int i = 0; i < contadorCliente; i++)
            {
                if (clientes[i].Identificacion != identificacion)
                {
                    return clientes[i];
                }
            }
            return null;
        }

        // Metodo para validar que el cliente que se esta ingresando no exista

        private static Cliente ClienteRepetido(string identificacion)
        {
            for (int i = 0; i < contadorCliente; i++)
            {
                if (clientes[i].Identificacion == identificacion)
                {
                    return clientes[i];
                }
            }
            return null;


        }
        //Metodo para validar que no se este creando una categoria repetida
        private static Categoria CategoriaRepetida(string categoriasServicios)
        {
            for (int i = 0; i < contadorCategoria; i++)
            {
                if (categorias[i].CategoriasServicios == categoriasServicios)
                {
                    return categorias[i];
                }
            }
            return null;


        }
        // Metodo para validar que la categoria de servicios exista
        private static Categoria CategoriaValida(string categoriaServicios)
        {
            for (int i = 0; i < contadorCategoria; i++)
            {
                if (categorias[i].CategoriasServicios != categoriaServicios)
                {
                    return categorias[i];
                }
            }
            return null;
        }
        //Metodo para validar que no se este agregando un Funcionario (ID) ya creado previamente
        private static Funcionario FuncionarioRepetido(string identificacion)
        {
            for (int i = 0; i < contadorFuncionario; i++)
            {
                if (funcionarios[i].Identificacion == identificacion)
                {
                    return funcionarios[i];
                }
            }
            return null;


        }
        // Metodo para validar que no se crean Hidrometros (Numero NIS) duplicados
        private static Hidrometro NisRepetido(string numeroNis)
        {
            for (int i = 0; i < contadorHidrometro; i++)
            {
                if (hidrometros[i].NumeroNis == numeroNis)
                {
                    return hidrometros[i];
                }
            }
            return null;


        }
    }
}


