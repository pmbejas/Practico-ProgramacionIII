using System;
using System.Collections.Generic;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program00
    {
        public static void Principal()
        {
            Console.Clear();
            Program.MostrarTitulo("Ejercicio 00 - Hola Mundo", ConsoleColor.DarkBlue,0);
            Console.WriteLine("Hola Mundo!!!");
            Console.WriteLine("Me llamo Pablo Bejas");
            Console.WriteLine("Actualmente me encentro cursando la materia");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Programacion III ");
            Console.ResetColor();
            Console.WriteLine("de la carrera");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Tecnicatura Universitaria en Programacion");
            Console.ResetColor();
            Console.Write("En la ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Universidad Tecnológica Nacional");
            Program.EsperarTeclaFinal();
        }
    }
}
