namespace Practico_ProgramacionIII
{
    internal class Program
    {
        public static class VariablesGlobales
        {
            public static string pieDePagina = "Programación III (Práctica) - Profesor: Rodrigo Esper - Alumno: Pablo Bejas";
        }

        public static int ReadInteger(string mensaje, ConsoleColor colorTexto)
        {
            int value;
            Console.ForegroundColor = colorTexto;
            Console.Write(mensaje);
            Console.ResetColor();
            int fila = Console.CursorTop;
            int columna = Console.CursorLeft;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, fila + 2);
                Console.WriteLine("No se ingresó un número entero");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Presiona cualquier tecla para intentar nuevamente...");
                Console.ReadKey();
                int cantidadEspacios = Console.WindowWidth - columna;
                Console.SetCursorPosition(columna, fila);
                Console.Write(new string(' ', cantidadEspacios));
                Console.SetCursorPosition(0, fila + 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, fila + 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.ResetColor();
                Console.SetCursorPosition(columna, fila);
            }
        }

        public static string ReadString(string mensaje, int cantidadCaracteresMinimo, int cantidadCaracteresMaximo, ConsoleColor colorTextoMensaje = ConsoleColor.White, ConsoleColor colorTextoValor = ConsoleColor.White, bool checkError = true)
        {
            string? value;
            Console.ForegroundColor = colorTextoMensaje;
            Console.Write(mensaje);
            Console.ForegroundColor = colorTextoValor;
            int fila = Console.CursorTop;
            int columna = Console.CursorLeft;
            while (true)
            {
                value = Console.ReadLine();
                if (!checkError)    
                {
                    return value ?? string.Empty;
                }

                if (value?.Length >= cantidadCaracteresMinimo && value?.Length <= cantidadCaracteresMaximo)
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, fila + 2);
                Console.WriteLine($"Debe Ingresar entre {cantidadCaracteresMinimo} y {cantidadCaracteresMaximo} caracteres");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Presiona cualquier tecla para intentar nuevamente...");
                Console.ReadKey();
                int cantidadEspacios = Console.WindowWidth - columna;
                Console.SetCursorPosition(columna, fila);
                Console.Write(new string(' ', cantidadEspacios));
                Console.SetCursorPosition(0, fila + 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, fila + 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.ResetColor();
                Console.SetCursorPosition(columna, fila);
            }
        }

        public static void EsperarTeclaFinal()
        {
            Console.SetCursorPosition(0, Console.CursorTop +2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Programa Finalizado");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        public static void MostrarTitulo(string titulo, ConsoleColor colorTexto, int linea)
        {
            Console.Title = titulo;
            Console.SetCursorPosition((Console.WindowWidth-titulo.Length) / 2, linea);
            Console.ForegroundColor = colorTexto;
            Console.Write(titulo);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ProgramaEnConstruccion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MostrarTitulo("Programa en Construcción", ConsoleColor.Yellow, (Console.WindowHeight /2) -4);
            MostrarTitulo("En breve sera puesto en funcionamiento", ConsoleColor.Yellow, (Console.WindowHeight / 2) - 2);
            MostrarTitulo("Disculpe las molestias ocasionadas", ConsoleColor.Yellow, (Console.WindowHeight / 2));
            MostrarTitulo("Presione Una Tecla Para Volver", ConsoleColor.Yellow, (Console.WindowHeight / 2) + 2);
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        public static void EsperarFinalSistema()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MostrarTitulo("Sistema Finalizado.", ConsoleColor.DarkGreen, (Console.WindowHeight / 2) - 3);
            MostrarTitulo("Gracias por su tiempo", ConsoleColor.DarkGreen, (Console.WindowHeight / 2) -1);
            MostrarTitulo("Presione cualquier tecla para salir", ConsoleColor.DarkGreen, (Console.WindowHeight / 2) + 1);
            Console.CursorVisible = false;
            Console.ForegroundColor= ConsoleColor.Black;
        }

        static void Main(string[] args)
        {
            int opcionElegida = 0;
            while (opcionElegida != 99)
            {
                Console.Clear();
                MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight-1);
                MostrarTitulo("Menú Principal", ConsoleColor.DarkBlue, 0);
                Console.WriteLine();
                Console.WriteLine("0. Program 00: Hola Mundo!!!");
                Console.WriteLine("1. Program 01: Registro y Login de Usuario"); 
                Console.WriteLine("2. Program 02");
                Console.WriteLine("3. Program 03");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("99. Salir");
                Console.WriteLine();
                opcionElegida = ReadInteger("Ingrese el número del programa a ejecutar: ", ConsoleColor.DarkGreen);
                Dictionary<int, Action> programas = new Dictionary<int, Action>
                {
                    { 0, Program00.Principal },
                    { 1, Program01.Principal },
                    { 2, Program02.Principal },
                    { 3, Program03.Principal }
                };

                if (programas.TryGetValue(opcionElegida, out Action? ejecutar))
                {
                    Console.Clear();
                    ejecutar();
                }
                else
                {
                    if (opcionElegida != 99)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción no válida. Selecciona una opción del menú.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                    else
                    {
                        EsperarFinalSistema();
                    }
                }
            }

        }
    }
}
