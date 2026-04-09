using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program09
    {
        public static void Principal()
        {
            string nombre = "Diego";
            string? apellido = null;

            Console.WriteLine(nombre.Length); // ✅ OK

            //Console.WriteLine(apellido.Length);
            // ⚠️ WARNING en compilación:
            // posible null reference

            Console.WriteLine("Fin ejemplo 1");

            Console.ReadKey();
        }
    }
}