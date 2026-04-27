using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;
using System.Threading;

namespace Practico_ProgramacionIII
{
    internal class Funciones
    {
        public static void TextoEnColor(string texto, ConsoleColor colorTexto, ConsoleColor colorOriginal)
        {
            Console.ForegroundColor = colorTexto;
            Console.Write(texto);
            Console.ForegroundColor = colorOriginal;
        }
        
        public static int ReadInteger(string mensaje, ConsoleColor colorTexto)
        {
            int value;
            Console.ForegroundColor = colorTexto;
            Console.Write(mensaje);
            Console.ResetColor();
            int fila = Console.CursorTop;
            int columna = Console.CursorLeft;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, fila + 2);
                Console.WriteLine("No se ingresó un número entero");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Presiona cualquier tecla para intentar nuevamente...");
                Console.ReadKey();
                int cantidadEspacios = Console.WindowWidth - columna;
                Console.SetCursorPosition(columna, fila);
                Console.Write(new string(' ', cantidadEspacios));
                Console.SetCursorPosition(0, fila + 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, fila + 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.ResetColor();
                Console.SetCursorPosition(columna, fila);
            }
        }

        public static double ReadDouble(string mensaje, ConsoleColor colorTexto)
        {
            double value;
            Console.ForegroundColor = colorTexto;
            Console.Write(mensaje);
            Console.ResetColor();
            int fila = Console.CursorTop;
            int columna = Console.CursorLeft;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, fila + 2);
                Console.WriteLine("No se ingresó un número valido");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Presiona cualquier tecla para intentar nuevamente...");
                Console.ReadKey();
                int cantidadEspacios = Console.WindowWidth - columna;
                Console.SetCursorPosition(columna, fila);
                Console.Write(new string(' ', cantidadEspacios));
                Console.SetCursorPosition(0, fila + 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, fila + 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.ResetColor();
                Console.SetCursorPosition(columna, fila);
            }
        }

        public static string ReadString(string mensaje, int cantidadCaracteresMinimo, int cantidadCaracteresMaximo, ConsoleColor colorTextoMensaje = ConsoleColor.White, ConsoleColor colorTextoValor = ConsoleColor.White, bool checkError = true)
        {
            string? value;
            Console.ForegroundColor = colorTextoMensaje;
            Console.Write(mensaje);
            Console.ForegroundColor = colorTextoValor;
            int fila = Console.CursorTop;
            int columna = Console.CursorLeft;
            while (true)
            {
                value = Console.ReadLine();
                if (!checkError)
                {
                    return value ?? string.Empty;
                }

                if (value?.Length >= cantidadCaracteresMinimo && value?.Length <= cantidadCaracteresMaximo)
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, fila + 2);
                Console.WriteLine($"Debe Ingresar entre {cantidadCaracteresMinimo} y {cantidadCaracteresMaximo} caracteres");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Presiona cualquier tecla para intentar nuevamente...");
                Console.ReadKey();
                int cantidadEspacios = Console.WindowWidth - columna;
                Console.SetCursorPosition(columna, fila);
                Console.Write(new string(' ', cantidadEspacios));
                Console.SetCursorPosition(0, fila + 2);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, fila + 3);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.ResetColor();
                Console.SetCursorPosition(columna, fila);
            }
        }

        public static void EsperarTeclaFinal()
        {
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Programa Finalizado");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        public static void EsperarTeclaFinalBlink()
        {
            Console.CursorVisible = false;
            int linea = Console.CursorTop + 2;
            while (!Console.KeyAvailable)
            {
                Console.SetCursorPosition(0, linea);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Programa Finalizado");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Thread.Sleep(100);
                Console.SetCursorPosition(0, linea);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Programa Finalizado");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Thread.Sleep(100);
                Console.SetCursorPosition(0, linea);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Programa Finalizado");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Thread.Sleep(100);
                Console.SetCursorPosition(0, linea);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Programa Finalizado");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Thread.Sleep(100);
            }
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        public static void MostrarTitulo(string titulo, ConsoleColor colorTexto, int linea, bool centrado = true)
        {
            Console.Title = titulo;
            int columna = centrado ? (Console.WindowWidth - titulo.Length) / 2 : 0;
            Console.SetCursorPosition(columna, linea);
            Console.ForegroundColor = colorTexto;
            Console.Write(titulo);
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ProgramaEnConstruccion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MostrarTitulo("Programa en Construcción", ConsoleColor.Yellow, (Console.WindowHeight / 2) - 4);
            MostrarTitulo("En breve sera puesto en funcionamiento", ConsoleColor.Yellow, (Console.WindowHeight / 2) - 2);
            MostrarTitulo("Disculpe las molestias ocasionadas", ConsoleColor.Yellow, (Console.WindowHeight / 2));
            MostrarTitulo("Presione Una Tecla Para Volver", ConsoleColor.Yellow, (Console.WindowHeight / 2) + 2);
            MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Console.CursorVisible = false;
            Console.ReadKey();
            Console.CursorVisible = true;
        }

        public static void EsperarFinalSistema()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            MostrarTitulo("Sistema Finalizado.", ConsoleColor.DarkGreen, (Console.WindowHeight / 2) - 3);
            MostrarTitulo("Gracias por su tiempo", ConsoleColor.DarkGreen, (Console.WindowHeight / 2) - 1);
            MostrarTitulo("Presione cualquier tecla para salir", ConsoleColor.DarkGreen, (Console.WindowHeight / 2) + 1);
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static string ReadPassword(string mensaje, ConsoleColor colorTextoMensaje = ConsoleColor.White, ConsoleColor colorTextoValor = ConsoleColor.White)
        {
            StringBuilder password = new StringBuilder();
            Console.ForegroundColor = colorTextoMensaje;
            Console.Write(mensaje);
            Console.ForegroundColor = colorTextoValor;

            const char caracterMask = '·';
            int fila = Console.CursorTop;
            int columna = Console.CursorLeft;
            bool visibleChar = false;
            while (true)
            {
                var keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.Enter)
                {
                    return password.ToString();
                }
                else if (keyPressed.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        Console.SetCursorPosition(columna + password.Length, fila);
                        Console.Write(" ");
                        Console.SetCursorPosition(columna + password.Length, fila);
                    }
                }
                else if (keyPressed.KeyChar >= 32 && keyPressed.KeyChar <= 126)
                {
                    password.Append(keyPressed.KeyChar);
                    if (visibleChar)
                    {
                        Console.Write(keyPressed.KeyChar);
                    }
                    else 
                    {
                        Console.Write(caracterMask);
                    }
                }
                else if (keyPressed.Key == ConsoleKey.G && keyPressed.Modifiers.HasFlag(ConsoleModifiers.Control))
                    {
                        if (visibleChar)
                        {
                            Console.SetCursorPosition(columna, fila);
                            Console.Write(new string(caracterMask, password.Length));
                            visibleChar = false;
                        }
                        else
                        {
                            Console.SetCursorPosition(columna, fila);
                            Console.Write(password.ToString());
                            visibleChar = true;
                        }                       
                    }
            }
        }
    
        public static void TituloRecuadro(string titulo, int filaInicial, ConsoleColor colorTexto, ConsoleColor colorLineas, int ancho, bool centrado = true)
        {
            int fila = filaInicial;
            string lineasRecuadro = new string('-', ancho);
            string espaciosRecuadro = new string(' ', ancho);
            string tituloMenuLinea = $"+{lineasRecuadro}+";
            string tituloMenuEspacios = $"|{espaciosRecuadro}|";
            int columna = centrado ? (Console.WindowWidth - titulo.Length) / 2 : 0;
            Funciones.MostrarTitulo(tituloMenuLinea, colorLineas, fila+1, centrado);
            Funciones.MostrarTitulo(tituloMenuEspacios, colorLineas, fila+2, centrado);
            Funciones.MostrarTitulo(tituloMenuLinea, colorLineas, fila+3, centrado);
            Console.ForegroundColor = colorTexto;
            int columnaTexto = centrado ? (Console.WindowWidth - titulo.Length) / 2 : (tituloMenuLinea.Length - titulo.Length) / 2;
            Console.SetCursorPosition(columnaTexto, fila+2);
            Console.Write(titulo);
            Console.ForegroundColor= colorTexto;
            Console.SetCursorPosition(columna, fila+4);
            Console.WriteLine();       
        }

        public static int GenerarMenu(OpcionMenu[] listadoOpciones, int filaInicial, ConsoleColor colorVineta = ConsoleColor.White, ConsoleColor colorOpcionColor = ConsoleColor.White, bool conMargenes=true)
        {
            void RemarcarOpcion(int opcionElegida, ConsoleColor colorFondo  , int anchoTotal)
            {
                Console.BackgroundColor = colorFondo;
                if (conMargenes) {
                    string margenes = new string(' ', anchoTotal);   
                    Console.SetCursorPosition(0, filaInicial+(opcionElegida*2)-1);
                    Console.Write(margenes);
                    Console.SetCursorPosition(0, filaInicial+(opcionElegida*2)+1);
                    Console.Write(margenes);
                }
                Console.SetCursorPosition(0, filaInicial+(opcionElegida*2));
                Funciones.TextoEnColor($"  {listadoOpciones[opcionElegida].Valor}. ", opcionElegida < listadoOpciones.Length-1 ? colorVineta : colorFondo, Globales.colorTextoMensaje);
                Console.Write(listadoOpciones[opcionElegida].Titulo);
                string espacios = new string(' ', anchoTotal-listadoOpciones[opcionElegida].Titulo.Length-listadoOpciones[opcionElegida].TituloColor.Length-listadoOpciones[opcionElegida].Valor.ToString().Length-4);
                Funciones.TextoEnColor(listadoOpciones[opcionElegida].TituloColor+espacios, colorOpcionColor, Globales.colorTextoMensaje);
            }

            void MostrarAyuda(int columna, int fila)
            {
                
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(columna, fila);
                Console.ForegroundColor = Globales.colorTextoMensaje;
                Console.WriteLine("+------------------------------------------+");
                Console.SetCursorPosition(columna, fila+1);
                Console.WriteLine("|                   Ayuda                  |");
                Console.SetCursorPosition(columna, fila+2);
                Console.WriteLine("+------------------------------------------+");
                Console.SetCursorPosition(columna, fila+3);
                Console.WriteLine("|                                          |");
                Console.SetCursorPosition(columna, fila+4);
                Console.Write("|     ");
                Funciones.TextoEnColor("↑ o ↓ para navegar por la opciones", ConsoleColor.Cyan, Globales.colorTextoMensaje);
                Console.WriteLine("   |");
                Console.SetCursorPosition(columna, fila+5);
                Console.WriteLine("|                                          |");
                Console.SetCursorPosition(columna, fila+6);
                Console.Write("|     ");
                Funciones.TextoEnColor("Enter para seleccionar la opcion", ConsoleColor.Cyan, Globales.colorTextoMensaje);
                Console.WriteLine("     |");
                Console.SetCursorPosition(columna, fila+7);
                Console.WriteLine("|                                          |");
                Console.SetCursorPosition(columna, fila+8);
                Console.Write("|     ");
                Funciones.TextoEnColor("Esc para salir del sistema", ConsoleColor.Cyan, Globales.colorTextoMensaje);
                Console.WriteLine("           |");
                Console.SetCursorPosition(columna, fila+9);
                Console.WriteLine("|                                          |");
                Console.SetCursorPosition(columna, fila+10);
                Console.WriteLine("+------------------------------------------+");
                Console.SetCursorPosition(columna, fila+12);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     Presione ENTER para Volver al Menú");
                var tecla = Console.ReadKey(true);
                while (tecla.Key != ConsoleKey.Enter)
                {
                    tecla = Console.ReadKey(true);
                }
                for (int i = 0; i <= 12; i++)
                {
                    Console.SetCursorPosition(columna, fila+i);
                    Console.WriteLine("                                            ");
                }

            }        

            int opcionElegida = 0;    
            Console.SetCursorPosition(0, filaInicial);
            int anchoTotal=0;
            for (int i = 0; i < listadoOpciones.Length; i++)
            {
                Funciones.TextoEnColor($"  {listadoOpciones[i].Valor}. ", i < listadoOpciones.Length-1 ? colorVineta : ConsoleColor.Black, Globales.colorTextoMensaje);
                Console.Write(listadoOpciones[i].Titulo);
                Funciones.TextoEnColor(listadoOpciones[i].TituloColor, colorOpcionColor, Globales.colorTextoMensaje);
                Console.WriteLine("\n");
                anchoTotal=Math.Max(anchoTotal, listadoOpciones[i].Valor.ToString().Length+listadoOpciones[i].Titulo.Length+listadoOpciones[i].TituloColor.Length+6);
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  F1: Ayuda");
            
            RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray, anchoTotal);
            Console.CursorVisible = false;
            while (true)
            {
                var keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (opcionElegida > 0)
                    {
                        RemarcarOpcion(opcionElegida, ConsoleColor.Black, anchoTotal);
                        
                        opcionElegida--;
                        
                        RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray, anchoTotal);
                    }
                    else
                    {
                        RemarcarOpcion(opcionElegida, ConsoleColor.Black, anchoTotal);
                        
                        opcionElegida = listadoOpciones.Length - 1;
                        
                        RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray, anchoTotal);
                    }
                }
                else if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    if (opcionElegida < listadoOpciones.Length - 1)
                    {
                        RemarcarOpcion(opcionElegida, ConsoleColor.Black, anchoTotal);
                        
                        opcionElegida++;
                        
                        RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray, anchoTotal);
                    }
                    else
                    {
                        RemarcarOpcion(opcionElegida, ConsoleColor.Black, anchoTotal);
                        
                        opcionElegida = 0;
                        
                        RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray, anchoTotal);
                    }
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    Console.CursorVisible = true;
                    return listadoOpciones[opcionElegida].Valor;
                }
                else if (keyPressed.Key == ConsoleKey.F1)
                {
                    RemarcarOpcion(opcionElegida, ConsoleColor.Black, anchoTotal);
                    MostrarAyuda(Console.WindowWidth-70, Console.WindowHeight-20);
                    RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray, anchoTotal);
                }
                else if (keyPressed.Key == ConsoleKey.Escape)
                {
                    Console.ResetColor();
                    return -1;
                }
            }
        }

        public static void EliminarLineas(int cantidadLineas, int linea)
        {
            for (int i = 0; i < cantidadLineas; i++)
            {
                Console.SetCursorPosition(0, linea + i);
                Console.Write(new string(' ', Console.WindowWidth));
            }
            Console.SetCursorPosition(0, linea);
        }
    }
}
