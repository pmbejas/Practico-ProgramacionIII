using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;

namespace Practico_ProgramacionIII
{
    public class Program01
    {
        public static void Principal()
        {
            string titulo = "Ejercicio 01 - Registro y Login de Usuario";
            Program.MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Program.MostrarTitulo(titulo, ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine("Pimero gurdaremos sus datos");
            Console.WriteLine("------ ---------- --- -----");
            Console.WriteLine();
            string user = Program.ReadString("Ingrese su nombre de usuario (4 a 20 caracteres): ", 4, 20, ConsoleColor.Yellow, ConsoleColor.White);
            string userPassword = Program.ReadString("Ingrese su contraseña (4 a 15 caracteres): ", 4, 15, ConsoleColor.Yellow, ConsoleColor.Black);
            string nombreCompleto = Program.ReadString("Ingrese su nombre completo (4 a 40 caracteres): ", 4, 40, ConsoleColor.Yellow, ConsoleColor.White);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Por favor, recuerde los datos que acaba de ingresar...");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Program.MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Program.MostrarTitulo(titulo, ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("|     Ingrese sus datos para iniciar sesión       |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("+-------------------------------------------------+");
            Console.SetCursorPosition(6, 6);
            string userIntented = Program.ReadString("Usuario: ", 1, 25, ConsoleColor.Yellow, ConsoleColor.White, false);
            Console.SetCursorPosition(6, 8);
            string userPasswordIntented = Program.ReadString("Contraseña: ", 1, 25, ConsoleColor.Yellow, ConsoleColor.Black, false);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (userIntented == user && userPasswordIntented == userPassword )
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(0, 12);
                Console.WriteLine($"Bienvenido, {nombreCompleto}!");
                Console.WriteLine("Has ingresado correctamente tus datos de inicio de sesión");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("Los datos ingresados son incorrectos.");
                Console.WriteLine("No se ha podido iniciar sesión.");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
            }
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;

        }
    }
}
