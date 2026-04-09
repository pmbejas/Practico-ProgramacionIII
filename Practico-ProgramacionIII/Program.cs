namespace Practico_ProgramacionIII
{
    internal class Program
    {
        public static class VariablesGlobales
        {
            public static string pieDePagina = "Programación III (Práctica) - Profesor: Rodrigo Esper - Alumno: Pablo Bejas";
            public static ConsoleColor colorTextoMensaje = ConsoleColor.White;
            public static ConsoleColor colorTextoTitulo = ConsoleColor.DarkYellow;
            public static ConsoleColor colorTextoVineta = ConsoleColor.DarkRed;
        }

        static void Main(string[] args)
        {
            int opcionElegida = 0;
            while (opcionElegida != 99)
            {
                Console.Clear();
                Funciones.MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight-1);
                const string tituloMenuLinea1 = "+-------------------------------------------------------+";
                const string tituloMenuLinea2 = "|                                                       |";
                const string tituloMenuLinea3 = "+-------------------------------------------------------+";
                const string tituloMenu = "Menu de Programas";
                Funciones.MostrarTitulo(tituloMenuLinea1, ConsoleColor.DarkCyan, 0);
                Funciones.MostrarTitulo(tituloMenuLinea2, ConsoleColor.DarkCyan, 1);
                Funciones.MostrarTitulo(tituloMenuLinea3, ConsoleColor.DarkCyan, 2);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition((Console.WindowWidth - tituloMenu.Length) / 2, 1);
                Console.Write(tituloMenu);
                Console.ForegroundColor= Program.VariablesGlobales.colorTextoMensaje;
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("  0. Program 00: Hola Mundo!!!\n");
                Console.WriteLine("  1. Program 01: Registro y Login de Usuario\n"); 
                Console.WriteLine("  2. Program 02: Tipos de Datos: int (Entero)\n");
                Console.WriteLine("  3. Program 03: Tipos de Datos: float, double y decimal\n");
                Console.WriteLine("  4. Program 04: Tipos de Datos: string (Cadena de Caracteres)\n");
                Console.WriteLine("  5. Program 05: Tipos de Datos: bool (Booleano)\n");
                Console.WriteLine("  6. Program 06: (En Construccion...)\n");
                Console.WriteLine("  7. Program 07: (En Construccion...)\n");
                Console.WriteLine("  8. Program 08: (En Construccion...)\n");
                Console.WriteLine("  9. Program 09: (En Construccion...)\n");
                Console.WriteLine("  10. Program 10:(En Construccion...)\n");
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("  99. Salir");
                Console.WriteLine();
                opcionElegida = Funciones.ReadInteger("Ingrese el número del programa a ejecutar: ", ConsoleColor.DarkGreen);
                Dictionary<int, Action> programas = new Dictionary<int, Action>
                {
                    { 0, Program00.Principal },
                    { 1, Program01.Principal },
                    { 2, Program02.Principal },
                    { 3, Program03.Principal },
                    { 4, Program04.Principal },
                    { 5, Program05.Principal },
                    { 6, Program06.Principal },
                    { 7, Program07.Principal },
                    { 8, Program08.Principal },
                    { 9, Program09.Principal },
                    { 10, Program10.Principal }
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
                        Funciones.EsperarFinalSistema();
                    }
                }
            }

        }
    }
}
