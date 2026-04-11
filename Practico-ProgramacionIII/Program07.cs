using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program07
    {
        public static void Principal()
        {
      
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Constantes de Calculo, control y representacion", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);
            
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Constantes de cálculo y control en C#");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("En el contexto de un sistema como un módulo de facturación, las constantes cumplen un rol");
            Console.WriteLine("fundamental porque permiten centralizar valores que:");
            Console.WriteLine("· No cambian nunca (como una tasa de impuesto fija)");
            Console.WriteLine("· Controlan el comportamiento del sistema (como un modo de prueba)");
            Console.WriteLine("· Representan símbolos o configuraciones globales");
            
            const decimal TASA_IVA = 0.21m;
            const decimal PORCENTAJE_DESCUENTO = 0.10m;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Constantes de cálculo:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Son aquellas que intervienen directamente en operaciones matemáticas.");
            Console.Write("  · ");
            Funciones.TextoEnColor($"const decimal TASA_IVA = {TASA_IVA}m;", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            Console.Write("  · ");
            Funciones.TextoEnColor($"const decimal PORCENTAJE_DESCUENTO = {PORCENTAJE_DESCUENTO}m;", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine("\n");

            const bool MODO_PRUEBA = false;
            const bool PRODUCCION = true;
            const int CANTIDAD_MAXIMA_INTENTOS = 3;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Constantes de control:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Sirven para definir el comportamiento del sistema. Por ejemplo:");
            Console.Write("");
            Console.Write("  · ");
            Funciones.TextoEnColor($"const bool MODO_PRUEBA = {MODO_PRUEBA};", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            Console.Write("  · ");
            Funciones.TextoEnColor($"const bool PRODUCCION = {PRODUCCION};", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            Console.Write("  · ");
            Funciones.TextoEnColor($"const int CANTIDAD_MAXIMA_INTENTOS = {CANTIDAD_MAXIMA_INTENTOS};", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine("\n");

            const char SIMBOLO_PESO = '$';
            const string SIMBOLO_GRADOS_CELSIUS = "°C";
            const string SIMBOLO_GRADOS_FAHRENHEIT = "°F";
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Constantes de representación:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("También se usan para definir valores simbólicos, como caracteres:");
            Console.Write("  · ");
            Funciones.TextoEnColor($"const char SIMBOLO_PESO = '{SIMBOLO_PESO}';", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            Console.Write("  · ");
            Funciones.TextoEnColor($"const string SIMBOLO_GRADOS_CELSIUS = '{SIMBOLO_GRADOS_CELSIUS}';", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            Console.Write("  · ");
            Funciones.TextoEnColor($"const string SIMBOLO_GRADOS_FAHRENHEIT = '{SIMBOLO_GRADOS_FAHRENHEIT}';", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine("\n");

            Funciones.EsperarTeclaFinal();
        }
    }
}