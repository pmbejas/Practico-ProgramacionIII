using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;

namespace Practico_ProgramacionIII
{
    public class Program03
    {
        public static void Principal()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos Float, Double y Decimal)", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Que son FLOAT, DECIMAL y DOUBLE en C#");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Estos tipos de datos se utilizan para almacenar números con decimales.");
            Console.Write("El tipo de dato ");
            Funciones.TextoEnColor("float", ConsoleColor.Cyan, ConsoleColor.White);
            Console.WriteLine(" ocupa 4 bytes. Se usa en gráficos, videojuegos y calculos donde importa la velocidad");

            Console.Write("El tipo de dato ");
            Funciones.TextoEnColor("double", ConsoleColor.Cyan, ConsoleColor.White);
            Console.WriteLine(" ocupa 8 bytes de memoria. Es el estándar y se usa en calculos cientifica, matematica, etc.");

            Console.Write("El tipo de dato ");
            Funciones.TextoEnColor("decimal", ConsoleColor.Cyan, ConsoleColor.White);
            Console.WriteLine(" ocupa 16 bytes de memoria. Se usa en dinero, finanzas y contabilidad");


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Forma de Uso");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Para declarar una variable de este tipo, al igual que con int, simplemente usas");
            Console.Write("la palabra clave ");
            Funciones.TextoEnColor("float, double o decimal", ConsoleColor.Cyan, ConsoleColor.White);
            Console.WriteLine(" seguida del nombre que quieras darle a la variable.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ejemplos:");
            Console.ForegroundColor = ConsoleColor.White;



            float velocidad = 10.5f;
            Console.Write("float velocidad = 10.5f; ");
            Funciones.TextoEnColor($"// WriteLine(velocidad) devuelve: {velocidad}", ConsoleColor.DarkGreen, ConsoleColor.White);
            Console.WriteLine();

            decimal precio = 19.99m;
            Console.Write("decimal precio = 19.99m; ");
            Funciones.TextoEnColor($"// WriteLine(precio) devuelve: {precio}", ConsoleColor.DarkGreen, ConsoleColor.White);
            Console.WriteLine();

            double pi = 3.14159265358979d;
            Console.Write("double pi = 3.14159265358979d; ");
            Funciones.TextoEnColor($"// WriteLine(pi) devuelve: {pi} (el sufijo d es optativo)", ConsoleColor.DarkGreen, ConsoleColor.White);
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();
        }
    }
}
