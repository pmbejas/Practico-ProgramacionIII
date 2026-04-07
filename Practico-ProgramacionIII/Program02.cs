using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;

namespace Practico_ProgramacionIII
{
    public class Program02
    {
        public static void Principal()
        {
            ConsoleColor colorTexto = ConsoleColor.White;
            ConsoleColor colorTitulo = ConsoleColor.Blue;
            Console.Clear();
            Funciones.MostrarTitulo(VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Ejercicio 02 - Tipo de Datos Enteros", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.ForegroundColor = colorTitulo;
            Console.WriteLine("Que es un INT en C#");
            Console.ForegroundColor = colorTexto;
            Console.WriteLine("Un int es un tipo de dato entero que se utiliza para almacenar números enteros sin decimales.");
            Console.Write("En C#, el tipo de dato ");
            Funciones.TextoEnColor("int", ConsoleColor.Cyan, colorTexto);
            Console.WriteLine(" tiene un rango de -2,147,483,648 a 2,147,483,647 y ocupa 4 bytes de memoria.");
            Console.WriteLine("Es uno de los tipos de datos más comunes y se utiliza para representar cantidades, contadores,");
            Console.WriteLine("índices y otros valores enteros en la programación.");
            Console.WriteLine();
            Console.ForegroundColor = colorTitulo;
            Console.WriteLine("Forma de Uso");
            Console.ForegroundColor = colorTexto;
            Console.WriteLine("Para declarar una variable de este tipo, simplemente usas");
            Console.Write("la palabra clave ");
            Funciones.TextoEnColor("int", ConsoleColor.Cyan, colorTexto);
            Console.WriteLine(" seguida del nombre que quieras darle.");
            Console.WriteLine();
            Console.ForegroundColor = colorTitulo;
            Console.WriteLine("Ejemplos:");
            Console.ForegroundColor = colorTexto;
                        
            int edad = 35;
            Console.Write("int edad = 35; ");
            Funciones.TextoEnColor("// WriteLine(edad) devuelve: ", ConsoleColor.DarkGreen, colorTexto);
            Funciones.TextoEnColor(edad.ToString(), ConsoleColor.Green, colorTexto);
            Console.WriteLine();
            
            int indice = 4;
            Console.Write("int indice = 4; ");
            Funciones.TextoEnColor("// WriteLine(indice) devuelve: ", ConsoleColor.DarkGreen, colorTexto);
            Funciones.TextoEnColor(indice.ToString(), ConsoleColor.Green, colorTexto);
            Console.WriteLine();

            int cantidadProductos = 12;
            Console.Write("int cantidadProductos = 12; ");
            Funciones.TextoEnColor("// WriteLine(cantidadProductos) devuelve: ", ConsoleColor.DarkGreen, colorTexto);
            Funciones.TextoEnColor(cantidadProductos.ToString(), ConsoleColor.Green, colorTexto);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("int a = 10, b = 3; ");
            int a = 10, b = 3;
            
            
            
            Console.Write("int suma = a + b; ");
            int suma = a + b;
            Funciones.TextoEnColor($"// Resultado : {suma}", ConsoleColor.DarkGreen, colorTexto);
            Console.WriteLine();

            Console.Write("int resta = a - b; ");
            int resta = a - b;
            Funciones.TextoEnColor($"// Resultado : {resta}", ConsoleColor.DarkGreen, colorTexto);
            Console.WriteLine();

            Console.Write("int multiplicacion = a * b; ");
            int multiplicacion = a * b;
            Funciones.TextoEnColor($"// Resultado : {multiplicacion}", ConsoleColor.DarkGreen, colorTexto);
            Console.WriteLine();

            Console.Write("int division = a * b; ");
            int division = a / b;
            Funciones.TextoEnColor($"// Resultado : {division} (En lugar de 3.33. Al ser int, se trunca la parte decimal)", ConsoleColor.DarkGreen, colorTexto);
            Console.WriteLine();

            Console.Write("int resto = a % b; ");
            int resto = a % b;
            Funciones.TextoEnColor($"// Resultado : {resto} (Lo que sobra de la división)", ConsoleColor.DarkGreen, colorTexto);
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();


        }
    }
}
