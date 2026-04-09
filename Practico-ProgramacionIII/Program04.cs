using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program04
    {   
        internal static void Ejercicio1()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos string (Cadena de Caracteres)", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("1. Pide al usuario que ingrese su nombre completo y luego: \n");
            Console.WriteLine("   a. muéstralo en pantalla.\n");
            Console.WriteLine("   b. muestra cuántos caracteres tiene su nombre completo (sin contar espacios).\n");
            Console.WriteLine("   c. muestra cuántas palabras tiene su nombre completo.\n");
            Console.WriteLine("   d. muestra sus iniciales.\n");
            Console.WriteLine("   e. muestra su nombre completo en mayúsculas y luego en minúsculas.\n");
            Console.WriteLine("   f. muestra su nombre completo al revés.\n");
            Console.WriteLine();
            
            string nombre = Funciones.ReadString("Ingrese su nombre: ", 3,30, ConsoleColor.White, ConsoleColor.DarkCyan, true).Trim();

            int cantidadTotalCaracteres = 0;
            int cantidadPalabras = nombre.Split(' ').Length;
            string iniciales = nombre[0].ToString();
            string nombreAlReves = "";
   
            for (int i = 0; i < nombre.Length; i++)
            {
                nombreAlReves += nombre[(nombre.Length-1) -i];
                if (nombre[i] != ' ')
                {
                    cantidadTotalCaracteres++;
                } else
                {
                    iniciales += nombre[i+1];
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo es: ");
            Funciones.TextoEnColor(nombre, ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" b. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo tiene ");
            Funciones.TextoEnColor(cantidadTotalCaracteres.ToString(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write(" caracteres (sin contar espacios).");
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" c. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo tiene ");
            Funciones.TextoEnColor(cantidadPalabras.ToString(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write(" palabras.");
            Console.WriteLine();
            
            Console.WriteLine();
            Funciones.TextoEnColor(" d. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tus iniciales son: ");
            Funciones.TextoEnColor(iniciales, ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" e. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo en mayúsculas es: ");
            Funciones.TextoEnColor(nombre.ToUpper(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" e. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo en minúsculas es: ");
            Funciones.TextoEnColor(nombre.ToLower(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" f. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo al revés es: ");
            Funciones.TextoEnColor(nombreAlReves, ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();
        }

        public static void Principal()
        {

            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos string (Cadena de Caracteres)", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Que son STRING en C#");
            Console.WriteLine("");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("El tipo de dato string se utiliza para almacenar texto. Es una secuencia de caracteres encerrada entre comillas dobles \"\".");
            Console.WriteLine("Se puede almacenar palabras, frases o incluso párrafos completos en una variable de tipo string.");
            
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Forma de Uso");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("Para declarar una variable de este tipo, al igual que con cualquier otro tipo de dato, simplemente usas");
            Console.Write("la palabra clave ");
            Funciones.TextoEnColor("string", ConsoleColor.Cyan, ConsoleColor.White);
            Console.WriteLine(" seguida del nombre que quieras darle a la variable.");
            Console.WriteLine();
            
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejemplo:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            string nombreCompleto = "Pablo Bejas";
            Console.Write("string nombreCompleto = \"Pablo Bejas\";");
            Funciones.TextoEnColor($"// WriteLine(nombreCompleto) devuelve: {nombreCompleto}", ConsoleColor.DarkGreen, ConsoleColor.White);
            Console.WriteLine();
            Funciones.EsperarTeclaFinal();
            
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("1. Pide al usuario que ingrese su nombre completo y luego: \n");
            Console.WriteLine("   a. muéstralo en pantalla.\n");
            Console.WriteLine("   b. muestra cuántos caracteres tiene su nombre completo (sin contar espacios).\n");
            Console.WriteLine("   c. muestra cuántas palabras tiene su nombre completo.\n");
            Console.WriteLine("   d. muestra sus iniciales.\n");
            Console.WriteLine("   e. muestra su nombre completo en mayúsculas y luego en minúsculas.\n");
            Console.WriteLine("   f. muestra su nombre completo al revés.\n");
            Console.WriteLine();
            
            string nombre = Funciones.ReadString("Ingrese su nombre: ", 3,30, ConsoleColor.White, ConsoleColor.DarkCyan, true).Trim();

            int cantidadTotalCaracteres = 0;
            int cantidadPalabras = nombre.Split(' ').Length;
            string iniciales = nombre[0].ToString();
            string nombreAlReves = "";
   
            for (int i = 0; i < nombre.Length; i++)
            {
                nombreAlReves += nombre[(nombre.Length-1) -i];
                if (nombre[i] != ' ')
                {
                    cantidadTotalCaracteres++;
                } else
                {
                    iniciales += nombre[i+1];
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo es: ");
            Funciones.TextoEnColor(nombreCompleto, ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" b. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo tiene ");
            Funciones.TextoEnColor(cantidadTotalCaracteres.ToString(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write(" caracteres (sin contar espacios).");
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" c. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo tiene ");
            Funciones.TextoEnColor(cantidadPalabras.ToString(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write(" palabras.");
            Console.WriteLine();
            
            Console.WriteLine();
            Funciones.TextoEnColor(" d. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write("Tus iniciales son: ");
            Funciones.TextoEnColor(iniciales, ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" e. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo en mayúsculas es: ");
            Funciones.TextoEnColor(nombre.ToUpper(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" e. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo en minúsculas es: ");
            Funciones.TextoEnColor(nombre.ToLower(), ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" f. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo al revés es: ");
            Funciones.TextoEnColor(nombreAlReves, ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();

        }
    }
}

