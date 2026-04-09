using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program08
    {
        public static void Principal()
        {
            // inferencia de tipo con var (sin estructuras de control)
            var x = 10;                       // int
            var y = 3.14;                     // double
            var mensaje = "Hola sin control"; // string

            // colecciones sin bucles explícitos
            var lista = new System.Collections.Generic.List<int> { 1, 2, 3 };
            var suma = lista[0] + lista[1] + lista[2];

            Console.WriteLine($"x = {x}, y = {y}, mensaje = {mensaje}");
            Console.WriteLine($"suma de lista = {suma}");

            // cálculo sin estructura de control
            var total = x + (int)y + suma;
            Console.WriteLine($"total = {total}");

            Console.ReadKey();
        }
    }
}