using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Practico_ProgramacionIII
{
    public class Program08
    {
        static void Movimiento(ref int fila, int movimientoFila, ref int columna, int movimientoColumna, int pasos, int[,] matriz, ref int numero, int esperaEnMs, int posicionFilaInicial, int posicionColumnaInicial)
        {
            for (int i = 1; i <= pasos; i++)
            {
                fila = fila + movimientoFila;
                columna = columna + movimientoColumna;
                matriz[fila, columna] = numero;
                Console.SetCursorPosition(posicionColumnaInicial+columna*5, posicionFilaInicial+fila*2);
                Console.Write(matriz[fila, columna]);
                Thread.Sleep(esperaEnMs);
                numero++;
            }           
        }

        public static void Principal()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Matriz Caracol", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);
            
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Matriz Caracol");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("La matriz caracol es una matriz que se llena de forma espiralada");
            Console.WriteLine("Se debera pedir al usuario que ingrese el rango de la matriz (impar).");
            Console.WriteLine("Luego se debera crear la matriz y llenarla con numeros enteros positivos");
            Console.WriteLine("comenzando desde el centro y avanzando hacia los bordes.");
            Console.WriteLine("Finalmente se debera mostrar la matriz en consola.");
            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.WriteLine();
            int rangoMatriz=0;
            int posicionMensaje = Console.CursorTop;
            while (rangoMatriz%2==0 || rangoMatriz<3 || rangoMatriz>15)
              {
                Console.SetCursorPosition(0, posicionMensaje);
                rangoMatriz = Funciones.ReadInteger("Ingrese el rango de la matriz (impar entre 3 y 15): ", ConsoleColor.White);
                if (rangoMatriz%2==0 || rangoMatriz<3 || rangoMatriz>15)
                {
                    Console.SetCursorPosition(0, posicionMensaje+2);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("El rango de la matriz debe ser impar, mayor o igual a 3 y menor o igual a 15");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey(true);
                    Console.SetCursorPosition(0, posicionMensaje+2);
                    Console.WriteLine(new string(' ', Console.WindowWidth));
                    Console.WriteLine(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, posicionMensaje);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
            }
            Console.CursorVisible = false;
            int[,] matriz = new int[rangoMatriz, rangoMatriz];
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Matriz Generada:");
            Console.ForegroundColor = ConsoleColor.Blue;

            int fila = rangoMatriz / 2;
            int columna = rangoMatriz / 2;
            int numero = 1;
            int pasos = 1;
            int esperaEnMs = 400/rangoMatriz;
            matriz[fila, columna] = numero;
            numero++;
            int posicionFilaInicial = Console.CursorTop+3;
            int posicionColumnaInicial = (Console.WindowWidth/2)-(rangoMatriz*5/2);
            Console.SetCursorPosition(posicionColumnaInicial+columna*5, posicionFilaInicial+fila*2);
            Console.Write(matriz[fila, columna]);
            Thread.Sleep(esperaEnMs);
            while (fila>=0)
            {
                Movimiento(ref fila, 0, ref columna, 1, pasos, matriz, ref numero, esperaEnMs, posicionFilaInicial, posicionColumnaInicial);
                Movimiento(ref fila, 1, ref columna, 0, pasos, matriz, ref numero, esperaEnMs, posicionFilaInicial, posicionColumnaInicial);
                pasos++;
                Movimiento(ref fila, 0, ref columna, -1, pasos, matriz, ref numero, esperaEnMs, posicionFilaInicial, posicionColumnaInicial);
                Movimiento(ref fila, -1, ref columna, 0, pasos, matriz, ref numero, esperaEnMs, posicionFilaInicial, posicionColumnaInicial);
                pasos++;
                
                if (fila==0)
                {
                    Movimiento (ref fila, 0, ref columna, 1, pasos-1, matriz, ref numero, esperaEnMs, posicionFilaInicial, posicionColumnaInicial);
                    fila--; 
                }
            }
            Console.SetCursorPosition(0, posicionFilaInicial+(rangoMatriz*2)+3);
            Funciones.EsperarTeclaFinal();
            
        }
    }
}