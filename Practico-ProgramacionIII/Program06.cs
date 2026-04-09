using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program06
    {
        public static void Principal()
        {
            // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");

            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);

            Console.ReadKey();
        }
    }
}