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

            /* static void MarquesinaFor(char[] arrayOriginal, char[] arrayMovido, int k)
            {
                for (int i=0; i<k;i++)
                {
                    arrayMovido[i]=arrayOriginal[arrayOriginal.Length - k + i];
                }
                for (int j=0; j<arrayOriginal.Length-k;j++)
                {
                    arrayMovido[j+k]=arrayOriginal[j];
                }
            } */

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
            string textoMarquesina = Funciones.ReadString("Ingrese un texto: ", 1, 50, ConsoleColor.White, ConsoleColor.White, false);
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
                arrayTexto = arrayTextoMovido.ToArray();                
                Console.SetCursorPosition(4, linea);
                foreach (char caracter in arrayTexto) Console.Write(caracter);
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

            int[] array = {1,2,3,4,5,6,7,8,9,10};
            
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Array Original:  ");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            foreach (int number in array) Console.Write($"{number}  ");
            Console.WriteLine("\n");

            for (int i = 0; i < (array.Length - i); i++)
            {
                int aux = array[(array.Length - 1) - i];
                array[array.Length-1 - i] = array[i];
                array[i]= aux;
            }

            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.Write("Array Invertido: ");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            foreach (int number in array) Console.Write($"{number}  ");
            
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

            int cantidadElementos = Funciones.ReadInteger("Ingrese la cantidad de elementos del Array: ", Globales.colorTextoMensaje);
            int [] array = new int[cantidadElementos];

            for (int i=0; i < cantidadElementos; i++)
            {
                array[i] = Funciones.ReadInteger($"Ingrese el elemento {i+1}: ", ConsoleColor.DarkCyan);
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Resultado: \n\n");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.Write("Array Original:   ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (int number in array) Console.Write($"{number}  ");
            Console.WriteLine("\n");

            for (int j=0; j < cantidadElementos; j++)
            {
                for (int i=0; i< cantidadElementos-1; i++)
                {
                    if (array[i]==0)
                    {
                        int variableAuxiliar = array[i];
                        array[i] = array[i+1];
                        array[i+1] = variableAuxiliar;
                    }
                }
            }

            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.Write("Array Compactado: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (int number in array) Console.Write($"{number}  ");
            Console.WriteLine("\n");

            Funciones.EsperarTeclaFinal();
        }

        static void Ejercicio6()
        {
            /*
            Consigna: Algoritmo de Ciclo Agrícola Autónomo (ACAA)
            1. Contexto del Problema
                Se debe desarrollar un programa que simule la lógica de un helicóptero agrícola encargado de gestionar una parcela de 3x3 celdas. El objetivo es que el alumno diseñe un algoritmo capaz de ejecutar ciclos completos de producción para tres tipos de productos: Zanahoria, Tomate y Cebolla, gestionando el inventario de forma programática.

            2. Definición de la Parcela
                El terreno se representará mediante una matriz de enteros de 3x3. Cada celda almacenará un valor numérico que representa su contenido:
                0: Suelo vacío.
                1: Zanahoria.
                2: Tomate.
                3: Cebolla.

            3. Reglas de Operación (Ciclo de Trabajo)
                El helicóptero debe operar de forma secuencial. El diseño del flujo de control es responsabilidad del alumno, pero debe respetar las siguientes fases obligatorias en cada ciclo:
                Fase de Siembra: El helicóptero debe recorrer las 9 celdas de la parcela y asignarles el código del producto elegido. El alumno debe decidir mediante código qué producto se plantará en cada ciclo.
                Restricción de Acción: No se permite realizar la cosecha en el mismo recorrido de siembra. El helicóptero debe completar la parcela entera antes de iniciar cualquier otra tarea.
                Fase de Cosecha: En un nuevo recorrido, el agente pasará por cada celda para recolectar el producto. Cada celda procesada sumará 3 unidades al inventario acumulado correspondiente.
                Fase de Limpieza (Desplantar): Una vez finalizada la cosecha de la parcela, el helicóptero debe realizar un recorrido adicional para resetear los valores de la matriz a 0. Esta fase es indispensable para habilitar el inicio de un nuevo ciclo de siembra.

            4. Requerimientos del Desarrollo
                Automatización: El programa no debe solicitar datos al usuario en cada vuelta; la lógica de qué sembrar y cuándo avanzar debe estar definida en el código.
                Gestión de Equidad: El algoritmo debe buscar que, tras varios ciclos, las cantidades totales en el inventario de Zanahorias, Tomates y Cebollas sean lo más parecidas posible.
                Salida de Datos: El programa debe imprimir en consola el estado de la matriz tras cada fase y mostrar el progreso del inventario global.

            Tips y Recomendaciones para la Resolución
                Para resolver este ejercicio con éxito utilizando programación estructurada, se sugieren los siguientes puntos:
                Estructura del Bucle Principal: Utilicen un bucle while o un ciclo determinado para simular los "días" o "vueltas" de la producción. Dentro de este bucle, llamen a los procesos de siembra, cosecha y limpieza.
                Lógica de Decisión de Siembra: Una forma eficiente de resolver la equidad es usar una variable de control o un contador. Por ejemplo: el ciclo 1 siembra Producto 1, el ciclo 2 Producto 2, y así sucesivamente; o bien, comparar los totales del inventario antes de decidir el próximo idProducto.
                Modularización: Es vital dividir el código en funciones (ej: void RealizarSiembra(int producto), void RealizarCosecha(), void LimpiarParcela()). Esto permite que el programa sea legible y fácil de mantener.
                Recorrido Uniforme: Para simular el movimiento del helicóptero, utilicen siempre bucles for anidados. Recuerden que acceder a matriz[i][j] representa la presencia física del helicóptero en esa celda.
                Inventario Global: Utilicen un arreglo de tamaño 3 (int stock[3]) declarado de forma que persista durante toda la ejecución, para que los datos no se pierdan al cambiar de ciclo.
                Visualización de Matrices: Creen una función pequeña para imprimir la matriz de 3x3. Ver la matriz llena de 1s, luego ver cómo el inventario sube y finalmente ver la matriz volver a 0s es la mejor forma de comprobar que el algoritmo funciona correctamente.
            */

            Cosecha.Principal();
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