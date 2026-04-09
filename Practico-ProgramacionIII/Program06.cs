using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Practico_ProgramacionIII
{
    public class Program06
    {
        internal static void Ejercicio1()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 1: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Sistema de Suscripción Premium");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
        
            Console.WriteLine();
            Console.WriteLine("Crea constantes para:");
            Funciones.TextoEnColor(" 1. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Nombre del servicio");
            Funciones.TextoEnColor(" 2. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Precio mensual (decimal)");
            Funciones.TextoEnColor(" 3. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Cantidad mínima de meses para suscribirse");
           
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Define un cliente con cierta cantidad de meses contratados");
            Funciones.TextoEnColor(" b. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Evalúa (en una constante booleana) si cumple el mínimo requerido");
            Funciones.TextoEnColor(" c. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Muestra toda la información por consola");

            const string NOMBRE_SERVICIO = "TradyOne Premium";
            const decimal PRECIO_MENSUAL = 19.99m;
            const int CANTIDAD_MINIMA_MESES = 3;
            int mesesContratados = 5;
            bool cumpleMinimo = mesesContratados >= CANTIDAD_MINIMA_MESES;

            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de variables:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine("   const string NOMBRE_SERVICIO = \"TradyOne Premium\";");
            Console.WriteLine("   const decimal PRECIO_MENSUAL = 19.99m;");
            Console.WriteLine("   const int CANTIDAD_MINIMA_MESES = 3;");
            Console.WriteLine("   int mesesContratados = 5;");
            Console.WriteLine("   bool cumpleMinimo = mesesContratados >= CANTIDAD_MINIMA_MESES;");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Muestra de valores:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine($"   Nombre del servicio: {NOMBRE_SERVICIO}");
            Console.WriteLine($"   Precio mensual: ${PRECIO_MENSUAL:F2}");
            Console.WriteLine($"   Cantidad mínima de meses: {CANTIDAD_MINIMA_MESES}");
            Console.WriteLine($"   Meses contratados: {mesesContratados}");
            Console.WriteLine($"   Cumple el mínimo requerido: {cumpleMinimo}");
            Console.WriteLine();
            Funciones.EsperarTeclaFinal();

        }
        internal static void Ejercicio2()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 1: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Control de compra online");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
        
            Console.WriteLine();
            Console.WriteLine("Define constantes para:");
            Funciones.TextoEnColor(" 1. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Monto mínimo de compra");
            Funciones.TextoEnColor(" 2. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Nombre de la tienda");
            Funciones.TextoEnColor(" 3. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Porcentaje de descuento (ej: 10%)");
           
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Declara un monto de compra");
            Funciones.TextoEnColor(" b. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Calcula si aplica el descuento (bool)");
            Funciones.TextoEnColor(" c. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Muestra si el cliente recibe descuento y cuánto pagaría");


            Funciones.EsperarTeclaFinal();
        }
        internal static void Ejercicio3()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 3:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Funciones.EsperarTeclaFinal();
        }
        internal static void Ejercicio4()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 4:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Funciones.EsperarTeclaFinal();
        }
        internal static void Ejercicio5()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 5:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Funciones.EsperarTeclaFinal();
        }
        public static void Principal()
        {
            int opcionElegida = -1;
            while (opcionElegida != 0)
            {
                Console.Clear();
                Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
                Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
                
                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Que son las constantes en C#");
                Console.WriteLine("");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.Write("En C#, una constante (");
                Funciones.TextoEnColor("const", ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
                Console.WriteLine(") es un valor que se define en tiempo de compilación y no");
                Console.WriteLine("puede cambiar durante la ejecución del programa. Es ideal para representar datos fijos");
                Console.WriteLine("como configuraciones, límites, mensajes o reglas del sistema.");

                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Forma de declarar constantes en C#");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine("La sintaxis para declarar una constante en C# es la siguiente:");
                Console.WriteLine();
                Funciones.TextoEnColor("    const tipo_de_dato", ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
                Console.Write(" NOMBRE_CONSTANTE = ");
                Funciones.TextoEnColor("valor", ConsoleColor.DarkRed, Program.VariablesGlobales.colorTextoMensaje);
                Console.WriteLine(";");
                Console.WriteLine();
                Console.Write("· Se declara con la palabra clave ");
                Funciones.TextoEnColor("const\n", ConsoleColor.DarkCyan, Program.VariablesGlobales.colorTextoMensaje);
                Console.WriteLine("· Debe inicializarse en el momento de su declaración.");
                Console.WriteLine("· Su valor es inmutable (no se puede modificar después).");
                Console.WriteLine("· Solo puede almacenar tipos simples o valores conocidos en compilación (como int, string, bool, etc.).");
                Console.WriteLine("· No puede ser una expresión que se evalúe en tiempo de ejecución (como DateTime.Now).");
                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Ejemplos:");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine("· const double PI = 3.14159;\n");
                Console.WriteLine("· const string MENSAJE_BIENVENIDA = \"¡Bienvenido al programa!\";\n");
                Console.WriteLine("· const int MAX_USUARIOS = 100;\n");
                Console.WriteLine("· const bool ES_ACTIVADO = true;\n");
                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Ejercitación:");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
        
                Console.WriteLine("A continuación se presentan una serie de ejercicios para practicar");
                Console.WriteLine("el uso de constantes.");

                Console.WriteLine("\n");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Menu de Opciones:");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine();
                Console.WriteLine("  1. Ejercicio 1: Sistema de Suscripción Premium");
                Console.WriteLine("  2. Ejercicio 2: Control de compra online");
                Console.WriteLine("  3. Ejercicio 3: Control de velocidad");
                Console.WriteLine("  4. Ejercicio 4: Sistema de aprobación");
                Console.WriteLine("  5. Ejercicio 5: Sistema de seguridad");
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("  0. Salir");
                Console.WriteLine();
                opcionElegida = Funciones.ReadInteger("Ejercicio a ejecutar?: ", ConsoleColor.DarkGreen);

                Action ejercicioAEjecutar = opcionElegida switch
                {
                    1 => Ejercicio1,
                    2 => Ejercicio2,
                    3 => Ejercicio3,
                    4 => Ejercicio4,
                    5 => Ejercicio5,
                    0 => () => { },
                    _ => () => 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opción no válida. Selecciona una opción del menú.");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                };

                ejercicioAEjecutar();
            }        
        
        
        }
    }
}