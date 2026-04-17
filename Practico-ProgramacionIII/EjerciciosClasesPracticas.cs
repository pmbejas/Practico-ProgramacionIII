using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;
using System.Threading;

namespace Practico_ProgramacionIII
{
    public class EjerciciosClasesPracticas
    {
        static void Ejercicio1()
        {
            Funciones.ProgramaEnConstruccion();
        }
        static void Ejercicio2()
        {
              Funciones.ProgramaEnConstruccion();
        }

        static void Ejercicio3()
        {
               Funciones.ProgramaEnConstruccion();
        }

        static void Ejercicio4()
        {            
             Funciones.ProgramaEnConstruccion();
        }

        static void Ejercicio5()
        {
             Funciones.ProgramaEnConstruccion();
        }

        static void Ejercicio6()
        {
            Funciones.ProgramaEnConstruccion();
        }

        public static void Principal()
        {
            Console.Clear();
            int opcionElegida = -1;
            while (opcionElegida != 0)
            {
                Console.Clear();
                Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight-1);
                Funciones.MostrarTitulo("Ejercitación de Clase", ConsoleColor.DarkBlue, 0);

                Console.WriteLine();

                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine("A continuación se presentan una serie de ejercicios propuestos");
                Console.WriteLine("por el profesor para realizar como trabajos prácticos");

                Console.WriteLine("\n");
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Menu de Opciones:");
                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine();
                Console.Write("  1. Ejercicio 1: ");
                Funciones.TextoEnColor("Permiso de Ingreso (Clase del dia 14/04/2026)", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  2. Ejercicio 2: ");
                Funciones.TextoEnColor("En Construcción", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  3. Ejercicio 3: ");
                Funciones.TextoEnColor("En Construcción", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  4. Ejercicio 4: ");
                Funciones.TextoEnColor("En Construcción", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  5. Ejercicio 5: ");
                Funciones.TextoEnColor("En Construcción", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  6. Ejercicio 6: ");
                Funciones.TextoEnColor("En Construcción", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("  0. Salir");
                Console.WriteLine();
                opcionElegida = Funciones.ReadInteger("Ejercicio a ejecutar?: ", ConsoleColor.DarkGreen);

                Action ejercicioAEjecutar = opcionElegida switch
                {
                    1 => () => Ejercicio1(),
                    2 => () => Ejercicio2(),
                    3 => () => Ejercicio3(),
                    4 => () => Ejercicio4(),
                    5 => () => Ejercicio5(),
                    6 => () => Ejercicio6(),
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