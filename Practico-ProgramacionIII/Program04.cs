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
            Funciones.MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos string (Cadena de Caracteres)", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.ForegroundColor = VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio:");
            Console.WriteLine();
            Console.ForegroundColor = VariablesGlobales.colorTextoMensaje;
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
            Console.ForegroundColor = VariablesGlobales.colorTextoMensaje;
            Funciones.TextoEnColor(" a. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo es: ");
            Funciones.TextoEnColor(nombre, ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" b. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo tiene ");
            Funciones.TextoEnColor(cantidadTotalCaracteres.ToString(), ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.Write(" caracteres (sin contar espacios).");
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" c. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write("Tu nombre completo tiene ");
            Funciones.TextoEnColor(cantidadPalabras.ToString(), ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.Write(" palabras.");
            Console.WriteLine();
            
            Console.WriteLine();
            Funciones.TextoEnColor(" d. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write("Tus iniciales son: ");
            Funciones.TextoEnColor(iniciales, ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" e. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo en mayúsculas es: ");
            Funciones.TextoEnColor(nombre.ToUpper(), ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" e. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo en minúsculas es: ");
            Funciones.TextoEnColor(nombre.ToLower(), ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine();
            Funciones.TextoEnColor(" f. ", VariablesGlobales.colorTextoVineta, VariablesGlobales.colorTextoMensaje);
            Console.Write($"Tu nombre completo al revés es: ");
            Funciones.TextoEnColor(nombreAlReves, ConsoleColor.DarkCyan, VariablesGlobales.colorTextoMensaje);
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();
        }

        public static void Principal()
        {

            Console.Clear();
            Funciones.MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos string (Cadena de Caracteres)", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.ForegroundColor = VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Que son STRING en C#");
            Console.WriteLine("");
            Console.ForegroundColor = VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("El tipo de dato string se utiliza para almacenar texto. Es una secuencia de caracteres encerrada entre comillas dobles \"\".");
            Console.WriteLine("Se puede almacenar palabras, frases o incluso párrafos completos en una variable de tipo string.");
            
            Console.WriteLine();
            Console.ForegroundColor = VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Forma de Uso");
            Console.ForegroundColor = VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("Para declarar una variable de este tipo, al igual que con cualquier otro tipo de dato, simplemente usas");
            Console.Write("la palabra clave ");
            Funciones.TextoEnColor("string", ConsoleColor.Cyan, ConsoleColor.White);
            Console.WriteLine(" seguida del nombre que quieras darle a la variable.");
            Console.WriteLine();
            
            Console.ForegroundColor = VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejemplo:");
            Console.WriteLine();
            Console.ForegroundColor = VariablesGlobales.colorTextoMensaje;
            string nombreCompleto = "Pablo Bejas";
            Funciones.TextoEnColor("string", ConsoleColor.Cyan, VariablesGlobales.colorTextoMensaje);
            Console.Write(" nombreCompleto = ");
            Funciones.TextoEnColor("\"Pablo Bejas\"", ConsoleColor.DarkRed, VariablesGlobales.colorTextoMensaje);
            Console.Write(";");
            Funciones.TextoEnColor($" // WriteLine(nombreCompleto) devuelve: {nombreCompleto}", ConsoleColor.DarkGreen, ConsoleColor.White);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.ForegroundColor = VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercitación:");
            Console.ForegroundColor = VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("A continuación se presenta un ejercicio para practicar el uso de variables string.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para continuar con el ejercicio...");
            Console.ReadKey();

            Ejercicio1();

        }
    }
}

