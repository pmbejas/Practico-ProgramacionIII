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

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Constantes de cálculo:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Son aquellas que intervienen directamente en operaciones matemáticas.");
            Console.WriteLine("  · const decimal TASA_IVA = 0.21m;");
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Si el valor del IVA cambia en el futuro, solo hay que modificarlo en un único lugar.");
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Constantes de control:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Sirven para definir el comportamiento del sistema. Por ejemplo:");
            Console.WriteLine("  · const bool MODO_PRUEBA = false;");
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Esta constante puede utilizarse para activar o desactivar funcionalidades,"); 
            Console.WriteLine("como logs, validaciones o simulaciones.");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Constantes de representación:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("También se usan para definir valores simbólicos, como caracteres:");
            Console.WriteLine("  · const char SIMBOLO_PESO = '$';");
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Esto mejora la legibilidad y evita repetir “valores mágicos” en el código.");         
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();
        }
    }
}