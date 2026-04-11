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
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 1: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Sistema de Suscripción Premium");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
        
            Console.WriteLine();
            Console.WriteLine("Crea constantes para:");
            Funciones.TextoEnColor(" 1. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nombre del servicio");
            Funciones.TextoEnColor(" 2. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Precio mensual (decimal)");
            Funciones.TextoEnColor(" 3. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Cantidad mínima de meses para suscribirse");
           
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Define un cliente con cierta cantidad de meses contratados");
            Funciones.TextoEnColor(" b. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Evalúa (en una constante booleana) si cumple el mínimo requerido");
            Funciones.TextoEnColor(" c. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Muestra toda la información por consola");

            const string NOMBRE_SERVICIO = "TradyOne Premium";
            const decimal PRECIO_MENSUAL = 19.99m;
            const int CANTIDAD_MINIMA_MESES = 3;
            int mesesContratados = 5;
            bool cumpleMinimo = mesesContratados >= CANTIDAD_MINIMA_MESES;

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Globales.colorTextoMensaje;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de variables:");
            Console.ForegroundColor = Globales.colorTextoMensaje;

            Console.WriteLine("   const string NOMBRE_SERVICIO = \"TradyOne Premium\";");
            Console.WriteLine("   const decimal PRECIO_MENSUAL = 19.99m;");
            Console.WriteLine("   const int CANTIDAD_MINIMA_MESES = 3;");
            Console.WriteLine("   int mesesContratados = 5;");
            Console.WriteLine("   bool cumpleMinimo = mesesContratados >= CANTIDAD_MINIMA_MESES;");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Muestra de valores:");
            Console.ForegroundColor = Globales.colorTextoMensaje;

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
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 2: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Control de compra online");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
        
            Console.WriteLine();
            Console.WriteLine("Define constantes para:");
            Funciones.TextoEnColor(" 1. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Monto mínimo de compra");
            Funciones.TextoEnColor(" 2. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nombre de la tienda");
            Funciones.TextoEnColor(" 3. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Porcentaje de descuento (ej: 10%)");
           
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Declara un monto de compra");
            Funciones.TextoEnColor(" b. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Calcula si aplica el descuento (bool)");
            Funciones.TextoEnColor(" c. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Muestra si el cliente recibe descuento y cuánto pagaría");

            const decimal MONTO_MINIMO_COMPRA = 150.00m;
            const string NOMBRE_TIENDA = "TradyOne Store";
            const decimal PORCENTAJE_DESCUENTO = 0.10m;

            decimal montoCompra = 120.00m;
            bool correspondeDescuento = montoCompra >= MONTO_MINIMO_COMPRA;
            
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de constantes:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"  const decimal MONTO_MINIMO_COMPRA = ${MONTO_MINIMO_COMPRA:F2}m;");
            Console.WriteLine("  const string NOMBRE_TIENDA = \"TradyOne Store\";");
            Console.WriteLine("  const decimal PORCENTAJE_DESCUENTO = 0.10m;");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de variables:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"decimal montoCompra = ${montoCompra:F2}m;");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Resultado:");
            Funciones.TituloRecuadro(NOMBRE_TIENDA, Console.CursorTop, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, 50, false);
            
            Console.Write($"Monto de compra: ");
            Funciones.TextoEnColor($"{montoCompra:F2}",ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            
            Console.Write($"Monto mínimo para descuento: ");
            Funciones.TextoEnColor($"{MONTO_MINIMO_COMPRA:F2}",ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine(correspondeDescuento 
                ? "El cliente recibe un descuento del 10%\nEl cliente pagaría: $" + (montoCompra * (1 - PORCENTAJE_DESCUENTO)).ToString("F2")
                : "El cliente no recibe descuento\nEl cliente pagaría: $" + montoCompra.ToString("F2"));
            
            Funciones.EsperarTeclaFinal();
        }
        internal static void Ejercicio3()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 3: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Control de Velocidad");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;

            Console.WriteLine();
            Console.WriteLine("Define constantes para:");
            Funciones.TextoEnColor(" 1. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Velocidad máxima permitida");
            Funciones.TextoEnColor(" 2. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nombre de la ruta");
            Funciones.TextoEnColor(" 3. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Multa fija");
           
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Declara la velocidad de un vehículo");
            Funciones.TextoEnColor(" b. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Evalúa si supera el límite");
            Funciones.TextoEnColor(" c. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Muestra si corresponde multa y el monto");
            
            const int VELOCIDAD_MAXIMA_PERMITIDA = 100;
            const string NOMBRE_RUTA = "Ruta 9";
            const decimal MULTA_FIJA = 500.00m;

            int velocidadVehiculo = 120;
            bool correspondeMulta = velocidadVehiculo > VELOCIDAD_MAXIMA_PERMITIDA;
            
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de constantes:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"  const int VELOCIDAD_MAXIMA_PERMITIDA = {VELOCIDAD_MAXIMA_PERMITIDA};");
            Console.WriteLine("  const string NOMBRE_RUTA = \"Ruta 9\";");
            Console.WriteLine("  const decimal MULTA_FIJA = 500.00m;");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de variables:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"int velocidadVehiculo = {velocidadVehiculo};");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Resultado:");
            Funciones.TituloRecuadro(NOMBRE_RUTA, Console.CursorTop, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, 50, false);
            
            Console.Write($"Velocidad del vehículo: ");
            Funciones.TextoEnColor($"{velocidadVehiculo}",ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            
            Console.Write($"Velocidad máxima permitida: ");
            Funciones.TextoEnColor($"{VELOCIDAD_MAXIMA_PERMITIDA}",ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine(correspondeMulta 
                ? "El vehículo excede la velocidad máxima permitida\nEl conductor debe pagar una multa de $" + MULTA_FIJA.ToString("F2")
                : "El vehículo no excede la velocidad máxima permitida\nEl conductor no debe pagar multa");
            
            Funciones.EsperarTeclaFinal();
        }
        internal static void Ejercicio4()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 4: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Sistema de aprobacion");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;

            Console.WriteLine();
            Console.WriteLine("Define constantes para:");
            Funciones.TextoEnColor(" 1. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nota mínima para aprobar");
            Funciones.TextoEnColor(" 2. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nombre del curso");
            Funciones.TextoEnColor(" 3. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nota máxima posible");
            
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Declara la nota de un alumno");
            Funciones.TextoEnColor(" b. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Evalúa si aprobó (bool)");
            Funciones.TextoEnColor(" c. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Muestra resultado y datos del curso");
            
            const int NOTA_MINIMA_APROBACION = 6;
            const string NOMBRE_CURSO = "Programación III";
            const int NOTA_MAXIMA_POSIBLE = 10;

            int notaAlumno = 8;
            bool aprobo = notaAlumno >= NOTA_MINIMA_APROBACION;
            
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de constantes:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"  const int NOTA_MINIMA_APROBACION = {NOTA_MINIMA_APROBACION};");
            Console.WriteLine("  const string NOMBRE_CURSO = \"Programación III\";");
            Console.WriteLine($"  const int NOTA_MAXIMA_POSIBLE = {NOTA_MAXIMA_POSIBLE};");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de variables:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"int notaAlumno = {notaAlumno};");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Resultado:");
            Funciones.TituloRecuadro(NOMBRE_CURSO, Console.CursorTop, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, 50, false);
            
            Console.Write($"Nota del alumno: ");
            Funciones.TextoEnColor($"{notaAlumno}",ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            
            Console.Write($"Nota mínima para aprobar: ");
            Funciones.TextoEnColor($"{NOTA_MINIMA_APROBACION}",ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();

            Console.WriteLine(aprobo 
                ? "El alumno aprobó el curso"
                : "El alumno no aprobó el curso");
            
            Funciones.EsperarTeclaFinal();
        }
        internal static void Ejercicio5()
        {
            
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Constanstes", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Ejercicio Nro. 5: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Sistema de seguridad");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;

            Console.WriteLine();
            Console.WriteLine("Define constantes para:");
            Funciones.TextoEnColor(" 1. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Intentos máximos permitidos");
            Funciones.TextoEnColor(" 2. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Nombre del sistema");
            Funciones.TextoEnColor(" 3. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Mensaje de bloqueo");
            
            Console.WriteLine();
            Console.WriteLine("Luego:");
            Funciones.TextoEnColor(" a. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Declara la cantidad de intentos realizados");
            Funciones.TextoEnColor(" b. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Evalúa si el usuario queda bloqueado");
            Funciones.TextoEnColor(" c. ", Globales.colorTextoVineta, Globales.colorTextoMensaje);
            Console.WriteLine("Muestra el estado del sistema");
            
            const int MAX_INTENTOS = 3;
            const string NOMBRE_SISTEMA = "Sistema de Seguridad";
            const string MENSAJE_BLOQUEO = "Usuario bloqueado por seguridad";

            int intentosRealizados = 2;
            bool estaBloqueado = intentosRealizados >= MAX_INTENTOS;

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de constantes:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"  const int MAX_INTENTOS = {MAX_INTENTOS}; // {MAX_INTENTOS} intentos máximos");
            Console.WriteLine($"  const string NOMBRE_SISTEMA = \"{NOMBRE_SISTEMA}\"; // {NOMBRE_SISTEMA}");
            Console.WriteLine($"  const string MENSAJE_BLOQUEO = \"{MENSAJE_BLOQUEO}\"; // {MENSAJE_BLOQUEO}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Declaracion de variables:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine($"int intentosRealizados = {intentosRealizados}; // {intentosRealizados} intentos");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Resultado:");
            
            Console.Write("Sistema: ");
            Funciones.TextoEnColor(NOMBRE_SISTEMA, ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            
            Console.Write("Intentos realizados: ");
            Funciones.TextoEnColor($"{intentosRealizados}", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();
            
            Console.Write("Intentos máximos: ");
            Funciones.TextoEnColor($"{MAX_INTENTOS}", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
            Console.WriteLine();

            if (estaBloqueado)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(MENSAJE_BLOQUEO);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usuario activo - No bloqueado");
            }

            Funciones.EsperarTeclaFinal();
        }
        public static void Principal()
        {
            int opcionElegida = -1;
            while (opcionElegida != 0)
            {
                Console.Clear();
                Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
                Funciones.TituloRecuadro("CONSTANTES", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);
                
                Console.WriteLine();
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Que son las constantes en C#");
                Console.WriteLine("");
                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.Write("En C#, una constante (");
                Funciones.TextoEnColor("const", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
                Console.WriteLine(") es un valor que se define en tiempo de compilación y no");
                Console.WriteLine("puede cambiar durante la ejecución del programa. Es ideal para representar datos fijos");
                Console.WriteLine("como configuraciones, límites, mensajes o reglas del sistema.");

                Console.WriteLine();
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Forma de declarar constantes en C#");
                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine("La sintaxis para declarar una constante en C# es la siguiente:");
                Console.WriteLine();
                Funciones.TextoEnColor("    const tipo_de_dato", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
                Console.Write(" NOMBRE_CONSTANTE = ");
                Funciones.TextoEnColor("valor", ConsoleColor.DarkRed, Globales.colorTextoMensaje);
                Console.WriteLine(";");
                Console.WriteLine();
                Console.Write("· Se declara con la palabra clave ");
                Funciones.TextoEnColor("const\n", ConsoleColor.DarkCyan, Globales.colorTextoMensaje);
                Console.WriteLine("· Debe inicializarse en el momento de su declaración.");
                Console.WriteLine("· Su valor es inmutable (no se puede modificar después).");
                Console.WriteLine("· Solo puede almacenar tipos simples o valores conocidos en compilación (como int, string, bool, etc.).");
                Console.WriteLine("· No puede ser una expresión que se evalúe en tiempo de ejecución (como DateTime.Now).");
                Console.WriteLine();
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Ejemplos:");
                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine("· const double PI = 3.14159;\n");
                Console.WriteLine("· const string MENSAJE_BIENVENIDA = \"¡Bienvenido al programa!\";\n");
                Console.WriteLine("· const int MAX_USUARIOS = 100;\n");
                Console.WriteLine("· const bool ES_ACTIVADO = true;\n");
                Console.WriteLine();
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Ejercitación:");
                Console.ForegroundColor = Globales.colorTextoMensaje;
        
                Console.WriteLine("A continuación se presentan una serie de ejercicios para practicar");
                Console.WriteLine("el uso de constantes.");

                Console.WriteLine("\n");
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Menu de Opciones:");
                Console.ForegroundColor = Globales.colorTextoMensaje;
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