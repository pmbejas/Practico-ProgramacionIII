using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program10
    {
        public static void Principal()
        {
            string? texto = null;

            int? longitud = texto?.Length;

            Console.WriteLine(longitud); // null

            Console.WriteLine("Fin ejemplo 3");

            Console.ReadKey();
        }
    }
}