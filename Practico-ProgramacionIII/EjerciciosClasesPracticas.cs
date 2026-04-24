using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;
using System.Threading;

namespace Practico_ProgramacionIII
{
    public class EjerciciosClasesPracticas
    {
        public class Alumno 
            {
                private string nombre {get; set;}
                private int nota1 {get; set;}
                private int nota2 {get; set;}

                public Alumno (string nombreClase, int nota1Clase, int nota2Clase)
                {
                    nombre = nombreClase;
                    nota1 = nota1Clase;
                    nota2 = nota2Clase;
                }

                public double CalcularPromedio()
                {
                    return (nota1 + nota2) /2;
                }

                public bool EstaAprobado()
                {
                    return CalcularPromedio() >= 6;
                }

                public void MostrarEstado()
                {
                    Console.WriteLine();
                    Console.ForegroundColor = Globales.colorTextoTitulo;
                    Console.Write($"Nombre de Alumno: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{nombre}\n");
                    Console.ForegroundColor = Globales.colorTextoTitulo;
                    Console.Write($"Promedio: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{CalcularPromedio()}\n");
                    
                    bool aprobado = EstaAprobado();
                    Console.ForegroundColor = Globales.colorTextoMensaje;
                    Console.Write($"Estado: ");
                    Console.ForegroundColor = aprobado ? ConsoleColor.Green : ConsoleColor.Red;
                    Console.WriteLine($"{(aprobado ? "Aprobado" : "Desaprobado")}");
                    Console.WriteLine();
                    /*if (EstaAprobado())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Estado: Aprobado");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Estado: Desaprobado");
                    }*/
                    //Console.WriteLine(Estaaprobado() ? "Estado: Aprobado" : "Estado: Desaprobado");
                }
            }

        static void Ejercicio1()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Ejercicio Clase 14/04/2026", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Permiso de Ingreso");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Solicite al usuario el nombre y la edad de 10 personas para generar un listado de control de acceso;");
            Console.WriteLine("el programa deberá permitir el ingreso únicamente a aquellas personas que sean mayores de 20 años,");
            Console.WriteLine("indicando explícitamente quiénes tienen el acceso permitido y quiénes lo tienen prohibido según su edad.");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.WriteLine();
            string[] arrayNombres = new string[10];
            int[] arrayEdades = new int[10];
            int linea = Console.CursorTop;
            for (int i=0; i < 10; i++)
            {
                Console.SetCursorPosition(0, linea);
                arrayNombres[i] = Funciones.ReadString("Ingrese el nombre: ", 3, 20);
                arrayEdades[i] = Funciones.ReadInteger("Ingrese la edad: ", ConsoleColor.White);
                Console.WriteLine();
                if (arrayEdades[i] > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acceso permitido");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Acceso prohibido");
                }
                Console.ReadKey(true);
                Funciones.EliminarLineas(4, linea);
            }
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Listado de Ingreso:");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            for (int i=0; i < 10; i++)
            {   
                Console.WriteLine($"{arrayNombres[i]}: {arrayEdades[i]} - {(arrayEdades[i] > 20 ? "Acceso permitido": "Acceso prohibido")}");
            }

            Funciones.EsperarTeclaFinalBlink();
        }
        static void Ejercicio2()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Ejercicio Clase 21/04/2026", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Sistema simple de alumnos");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Crear una clase Alumno que tenga:");
            Console.WriteLine("   · Nombre");
            Console.WriteLine("   · Nota1");
            Console.WriteLine("   · Nota2");
            Console.WriteLine("Y que resuelva estos puntos:");
            Console.WriteLine("   1.Un constructor que reciba nombre, nota1 y nota2.");
            Console.WriteLine("   2.Un método CalcularPromedio() que devuelva el promedio.");
            Console.WriteLine("   3.Un método EstaAprobado() que devuelva true si el promedio es mayor o igual a 6.");
            Console.WriteLine("   4.Un método MostrarEstado() que imprima:");
            Console.WriteLine("      · nombre");
            Console.WriteLine("      · promedio");
            Console.WriteLine("      · si está aprobado o desaprobado");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.WriteLine();

            string nombre = Funciones.ReadString("Ingrese el nombre del alumno: ", 3, 20);
            int nota1 = Funciones.ReadInteger("Ingrese la primera nota: ", ConsoleColor.DarkCyan);
            int nota2 = Funciones.ReadInteger("Ingrese la segunda nota: ", ConsoleColor.DarkCyan);
            
            Alumno alumno = new Alumno(nombre, nota1, nota2);
            alumno.MostrarEstado();
            
            Funciones.EsperarTeclaFinal();
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
                Funciones.TextoEnColor("Permiso de Ingreso (Clase del día 14/04/2026)", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  2. Ejercicio 2: ");
                Funciones.TextoEnColor("Sistema simple de alumnos (Clase del día 21/04/2026)", ConsoleColor.DarkCyan, ConsoleColor.White);
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