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
            public static ConsoleColor colorTextoMenu = ConsoleColor.DarkCyan;
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
                
                string [] opciones = new string[]
                {
                    "Program 00: ", "Program 01: ", "Program 02: ", "Program 03: ",
                    "Program 04: ", "Program 05: ", "Program 06: ", "Program 07: ",
                    "Program 08: ", "Program 09: ", "Program 10: "
                };

                string [] opcionesColor = new string[]
                {
                    "Hola Mundo!!!",
                    "Registro y Login de Usuario",
                    "Tipos de Datos: int (Entero)",
                    "Tipos de Datos: float, double y decimal",
                    "Tipos de Datos: string (Cadena de Caracteres)",
                    "Tipos de Datos: bool (Booleano)",
                    "Constantes",
                    "(En Construccion...)",
                    "(En Construccion...)",
                    "(En Construccion...)",
                    "(En Construccion...)"
                };
                
                opcionElegida = Funciones.GenerarMenu(opciones, opcionesColor, 0, 99, 5, ConsoleColor.DarkYellow, ConsoleColor.DarkCyan);
                
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
