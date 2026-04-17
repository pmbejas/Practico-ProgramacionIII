using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;
using System.Threading;

namespace Practico_ProgramacionIII
{
    public class Ejercitacion
    {
        static void Ejercicio1()
        {
            int sumaNotas = 0;
           int[] notas = {1,2,3,4,5,6,7,8,9,10};
           string[] nombres = {"pepito", "juan", "carla", "maria", "mumi", "damian", "aylen", "francisco", "alejo", "pablo"}; 
           for (int i=0; i<notas.Length;i++)
           {
             sumaNotas += notas[i];
           }
           double promedio = sumaNotas / notas.Length; 
           Console.WriteLine("El promedio de las notas es: " + promedio);
           int[] superiorPromedio = new int[notas.Length];
           string[] nombreSuperiorPromedio = new string[notas.Length]; 
           int contadorNotas = 0;
           for (int i=0; i< notas.Length;i++)
           {
            if (notas[i] > promedio)
            {
                contadorNotas++;
                superiorPromedio[i] = notas[i];
                nombreSuperiorPromedio[i] = nombres[i];
            }
           }
           Console.WriteLine($"Hay {contadorNotas} superiores al promedio");
           for (int indice=0; indice<contadorNotas;indice++)
           {
            Console.WriteLine($"El alumno {nombreSuperiorPromedio[indice]} obtuvo una nota de {superiorPromedio[indice]}");
           }
           Funciones.EsperarTeclaFinal();
        }
        static void Ejercicio2()
        {
            /*
            2) El Detector de Duplicados (Sin usar Sets)
               Dado un array de números enteros, los alumnos deben crear un programa 
              que identifique si existe algún número repetido.
            */
            List<int> numeros = new List<int>();
            int cantidadNumeros = Funciones.ReadInteger("Ingrese la cantidad de numeros: ", ConsoleColor.White);
            for (int i=0; i<cantidadNumeros;i++)
            {
                int numero = Funciones.ReadInteger("Ingrese un numero: ", ConsoleColor.White);
                numeros.Add(numero);
            }

            Funciones.EsperarTeclaFinal();
            
        }

        static void Ejercicio3()
        {
            static void Marquesina(char[] arrayOriginal, char[] arrayMovido, int k)
            {
                for (int i = 0; i < arrayOriginal.Length; i++)
                {
                    int nuevaPosicion = (i + k) % arrayOriginal.Length;
                    arrayMovido[nuevaPosicion] = arrayOriginal[i];
                }
            }

            static void MarquesinaFor(char[] arrayOriginal, char[] arrayMovido, int k)
            {
                for (int i=0; i<k;i++)
                {
                    arrayMovido[i]=arrayOriginal[arrayOriginal.Length - k + i];
                }
                for (int j=0; j<arrayOriginal.Length-k;j++)
                {
                    arrayMovido[j+k]=arrayOriginal[j];
                }
            }

            static void RotarArray(int[] arrayOriginal, int[] arrayMovido, int k)
            {
                for (int i = 0; i < arrayOriginal.Length; i++)
                {
                    int nuevaPosicion = (i + k) % arrayOriginal.Length;
                    arrayMovido[nuevaPosicion] = arrayOriginal[i];
                }
            }

            static void RotarArrayFor(int[] arrayOriginal, int[] arrayMovido, int k)
            {
                for (int i=0; i<k;i++)
                {
                    arrayMovido[i]=arrayOriginal[arrayOriginal.Length - k + i];
                }
                for (int j=0; j<arrayOriginal.Length-k;j++)
                {
                    arrayMovido[j+k]=arrayOriginal[j];
                }
            }

            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Rotacion de Elementos", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Rotacion de Elementos (El \"Carrusel\")");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Dado un array de N elementos y un número K, el programa debe desplazar todos los elementos");
            Console.WriteLine("K posiciones a la derecha. Los elementos que \"salen\" por el final deben volver a entrar por el principio.");
            Console.WriteLine("Ejemplo: [1, 2, 3, 4, 5] con K=2 resulta en [4, 5, 1, 2, 3].");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.WriteLine();
            int[] arrayOriginal = {1,2,3,4,5,6,7,8,9};
            int[] arrayMovido = new int[arrayOriginal.Length];
            int k = Funciones.ReadInteger("Ingrese el numero de posiciones a desplazar: (1 a 8)", ConsoleColor.White);
            
            Console.WriteLine("\n");
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Array Original: ");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            foreach (int number in arrayOriginal) Console.Write($"{number}  ");

            // Variante: usando dos bucles for
            RotarArrayFor(arrayOriginal, arrayMovido, k);
            Console.WriteLine("\n");
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Array Movido: ");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            foreach (int number in arrayMovido) Console.Write($"{number}  ");

             // Alternativa: usando el operador módulo (%)
            RotarArray(arrayOriginal, arrayMovido, k);
            Console.WriteLine("\n");
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Array Movido (con operador módulo): ");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            foreach (int number in arrayMovido) Console.Write($"{number}  ");
            
            Console.WriteLine("\n");
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("MARQUESINA: ");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            string textoMarquesina = Funciones.ReadString("Ingrese un texto: ", 1, 100, ConsoleColor.White, ConsoleColor.White, false);
            textoMarquesina = textoMarquesina + " - ";
            char[] arrayTexto = textoMarquesina.ToCharArray();
            char[] arrayTextoMovido = new char[arrayTexto.Length];
            int linea = Console.CursorTop+1;
            Console.SetCursorPosition(0, linea+2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Presione cualquier tecla para detener la marquesina");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.CursorVisible = false;
            while (!Console.KeyAvailable)
            {
                Marquesina(arrayTexto, arrayTextoMovido, arrayTexto.Length-1);
                arrayTexto = arrayTextoMovido.Clone() as char[];                
                Console.SetCursorPosition(4, linea);
                foreach (char c in arrayTexto) Console.Write(c);
                Console.WriteLine();
                Thread.Sleep(100);
            }
            Console.CursorVisible = true;

            Funciones.EsperarTeclaFinal();
        }

        static void Ejercicio4()
        {            
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Inversion In-place", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Inversion In-place");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Se debera invertir el orden de un array dado (el primero pasa a ser el último, etc.), ");
            Console.WriteLine("pero con una restricción estricta: no puede usar un segundo array de apoyo.");
            Console.WriteLine("Debe hacerlo modificando el original.");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.WriteLine();

            Funciones.EsperarTeclaFinalBlink();
        }

        static void Ejercicio5()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Compactador de Ceros", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Compactador de Ceros");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("Dado un array que contiene números y varios ceros (ej: [0, 5, 0, 3, 12, 0]),"); 
            Console.WriteLine("el programa debe mover todos los ceros al final del array, ");
            Console.WriteLine("manteniendo el orden relativo de los demás números.");
            Console.WriteLine("Resultado: [5, 3, 12, 0, 0, 0].");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.WriteLine();

            Funciones.EsperarTeclaFinal();
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
                Funciones.MostrarTitulo("Ejercitación Adicional", ConsoleColor.DarkBlue, 0);

                Console.WriteLine();

                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine("A continuación se presentan una serie de ejercicios para practicar");
                Console.WriteLine("La idea es practicar y adquirir logica de programación mediante");
                Console.WriteLine("la resolución de distintos problemas");

                Console.WriteLine("\n");
                Console.ForegroundColor = Globales.colorTextoTitulo;
                Console.WriteLine("Menu de Opciones:");
                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine();
                Console.Write("  1. Ejercicio 1: ");
                Funciones.TextoEnColor("Ranking de Notas", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  2. Ejercicio 2: ");
                Funciones.TextoEnColor("Detector de Duplicados", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  3. Ejercicio 3: ");
                Funciones.TextoEnColor("Carrusel de Elementos", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  4. Ejercicio 4: ");
                Funciones.TextoEnColor("Inversión In-place", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  5. Ejercicio 5: ");
                Funciones.TextoEnColor("Compactador de Ceros", ConsoleColor.DarkCyan, ConsoleColor.White);
                Console.WriteLine();
                Console.Write("  6. Ejercicio 6: ");
                Funciones.TextoEnColor("Cosecha de Productos", ConsoleColor.DarkCyan, ConsoleColor.White);
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


/*
Buen día.
Traten de resolver estos ejercicios:

1) El Ranking de Notas (Filtro y Promedio):
Crear un programa que reciba un array de notas (0-10). 
Debe calcular el promedio y luego generar un nuevo array que contenga 
solo las notas que están por encima de ese promedio.

2) El Detector de Duplicados (Sin usar Sets)
Dado un array de números enteros, los alumnos deben crear un programa 
que identifique si existe algún número repetido.

3) Rotación de Elementos (El "Carrusel")
El reto: Dado un array de N elementos y un número K, el programa debe desplazar todos los elementos 
K posiciones a la derecha. Los elementos que "salen" por el final deben volver a entrar por el principio.
Ejemplo: [1, 2, 3, 4, 5] con K=2 resulta en [4, 5, 1, 2, 3].

4) Inversión In-place (Sin array auxiliar)
El reto: El alumno debe invertir el orden de un array (el primero pasa a ser el último, etc.), pero con una restricción estricta: no puede usar un segundo array de apoyo. Debe hacerlo modificando el original.

5) Compactador de Ceros
El reto: Dado un array que contiene números y varios ceros (ej: [0, 5, 0, 3, 12, 0]), el programa debe mover todos los ceros al final del array, manteniendo el orden relativo de los demás números.
Resultado: [5, 3, 12, 0, 0, 0].
*/