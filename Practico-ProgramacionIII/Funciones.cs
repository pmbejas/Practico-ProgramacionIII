using System;
using System.Collections.Generic;
using System.Text;
using static Practico_ProgramacionIII.Program;

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
        }

        public static int GenerarMenu(OpcionMenu[] listadoOpciones, int filaInicial, ConsoleColor colorVineta = ConsoleColor.White, ConsoleColor colorOpcionColor = ConsoleColor.White, bool conMargenes=true)
        {
            void RemarcarOpcion(int opcionElegida, ConsoleColor colorFondo)
            {
                Console.BackgroundColor = colorFondo;
                if (conMargenes) {
                    string margenes = new string(' ', listadoOpciones[opcionElegida].Titulo.Length+listadoOpciones[opcionElegida].TituloColor.Length+7);   
                    Console.SetCursorPosition(0, filaInicial+(opcionElegida*2)-1);
                    Console.Write(margenes);
                    Console.SetCursorPosition(0, filaInicial+(opcionElegida*2)+1);
                    Console.Write(margenes);
                }
                Console.SetCursorPosition(0, filaInicial+(opcionElegida*2));
                Funciones.TextoEnColor($"  {listadoOpciones[opcionElegida].Valor}. ", colorVineta, Globales.colorTextoMensaje);
                Console.Write(listadoOpciones[opcionElegida].Titulo);
                Funciones.TextoEnColor(listadoOpciones[opcionElegida].TituloColor+"  ", colorOpcionColor, Globales.colorTextoMensaje);
            }        

            int opcionElegida = 0;    
            Console.SetCursorPosition(0, filaInicial);
            for (int i = 0; i < listadoOpciones.Length; i++)
            {
                Funciones.TextoEnColor($"  {listadoOpciones[i].Valor}. ", colorVineta, Globales.colorTextoMensaje);
                Console.Write(listadoOpciones[i].Titulo);
                Funciones.TextoEnColor(listadoOpciones[i].TituloColor, colorOpcionColor, Globales.colorTextoMensaje);
                Console.WriteLine("\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  Presione ↑ o ↓ para navegar por las opciones y Enter para seleccionar\n");
            Console.WriteLine("  Presione Esc para salir del sistema");
            
            RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray);

            while (true)
            {
                var keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (opcionElegida > 0)
                    {
                        RemarcarOpcion(opcionElegida, ConsoleColor.Black);
                        
                        opcionElegida--;
                        
                        RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray);
                    }
                }
                else if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    if (opcionElegida < listadoOpciones.Length - 1)
                    {
                        RemarcarOpcion(opcionElegida, ConsoleColor.Black);
                        
                        opcionElegida++;
                        
                        RemarcarOpcion(opcionElegida, ConsoleColor.DarkGray);
                    }
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    return listadoOpciones[opcionElegida].Valor;
                }
                else if (keyPressed.Key == ConsoleKey.Escape)
                {
                    Console.ResetColor();
                    return -1;
                }
            }
        }
    }
}
