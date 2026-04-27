using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Practico_ProgramacionIII
{
    public class Cosecha
    {
        static int tiempoEspera = 0;
        static string[] productos = {"Zanahoria", "Tomate", "Cebolla"};
        static int[] cantidadCosechada = {0,0,0};
        static int productoActivo = -1;
        static int rango = 3;
        static int[,] estadoParcela = new int[rango,rango];
        static int[,] parcela = new int[rango,rango];
        static int columnaInicial = (Console.WindowWidth-rango*9)/2;
        static int filaInicial = (Console.WindowHeight-rango*5)/2;



        static void DibujarTabla(string[] productos, int ancho, int alto, int columna, int fila)
        {
            DibujarVentana(" ", ancho, alto, columna, fila);
            int cantidadProductos = productos.Length;
            int anchoCelda = (ancho / cantidadProductos);
            for (int i = 1; i < cantidadProductos; i++)
            {
                for (int j=1; j<alto;j++)
                {
                    Console.SetCursorPosition(columna+(anchoCelda*i), fila+j);
                    Console.Write("│");
                }
                Console.SetCursorPosition(columna+(anchoCelda*i), fila);
                Console.Write("┬");
                Console.SetCursorPosition(columna+(anchoCelda*i), fila+2);
                Console.Write("┼");
                Console.SetCursorPosition(columna+(anchoCelda*i), fila+alto);
                Console.Write("┴");
                Console.SetCursorPosition(columna+((i-1)*anchoCelda)+2,fila+1);
                Console.Write(productos[i-1]);
                Console.SetCursorPosition(columna+((i-1)*anchoCelda)+7,fila+4);
                Console.Write(cantidadCosechada[i-1]);
            }
            Console.SetCursorPosition(columna+((cantidadProductos-1)*anchoCelda)+2,fila+1);
            Console.Write(productos[cantidadProductos-1]);
            Console.SetCursorPosition(columna+((cantidadProductos-1)*anchoCelda)+7,fila+4);
            Console.Write(cantidadCosechada[cantidadProductos-1]);
        }

        static void DivisorVentana(int ancho, int columna, int fila)
        {
            for (int i = 1; i <= ancho; i++)
            {
                Console.SetCursorPosition(columna + i, fila);
                Console.Write("─");
            }
            Console.SetCursorPosition(columna, fila);
            Console.Write("├");
            Console.SetCursorPosition(columna+ancho, fila);
            Console.Write("┤");
        }
        
        static void DibujarVentana(string titulo, int ancho, int alto, int columna, int fila, ConsoleColor colorLinea = ConsoleColor.White)
        {
            
            Console.ForegroundColor = colorLinea;
            for (int i = 1; i <= ancho; i++)
            {
                Console.SetCursorPosition(columna+i, fila);
                Console.Write("─");
                Console.SetCursorPosition(columna+i, fila+alto);
                Console.Write("─");
            }
            for (int i = 1; i <= alto; i++)
            {
                Console.SetCursorPosition(columna, fila+i);
                Console.Write("│");
                Console.SetCursorPosition(columna+ancho, fila+i);
                Console.Write("│");
            }
            Console.SetCursorPosition(columna, fila);
            Console.Write("┌");
            Console.SetCursorPosition(columna+ancho, fila);
            Console.Write("┐");
            Console.SetCursorPosition(columna, fila+alto);
            Console.Write("└");
            Console.SetCursorPosition(columna+ancho, fila+alto);
            Console.Write("┘");
            if (titulo.Length > 0)
            {
                DivisorVentana(ancho, columna, fila+2);
                Console.SetCursorPosition(columna+(((ancho - titulo.Length)/2)), fila + 1);
                Console.Write(titulo);
            }
        }
        
        static void MostrarReferencia(string referencia, int columna, int fila, ConsoleColor color)
        {
            Console.SetCursorPosition(columna, fila);
            Funciones.TextoEnColor("████   ", color, ConsoleColor.White);
            Console.Write(referencia);
            Console.ResetColor();
        }

        static void VentanaMenu(int ancho, int alto, int columna, int fila)
        {
            DibujarVentana("Menu de Opciones", ancho, alto, columna, fila);
            MostrarReferencia("1. Limpiar Parcelas", columna + 1, fila + 5, ConsoleColor.Black);
            MostrarReferencia("2. Plantar", columna + 1, fila + 7, ConsoleColor.Black);
            MostrarReferencia("3. Cosechar", columna + 1, fila + 9, ConsoleColor.Black);
            MostrarReferencia("4. Cambiar Producto", columna + 1, fila + 11, ConsoleColor.Black);
            MostrarReferencia("0. Salir del Juego", columna + 1, fila + 13, ConsoleColor.Black);
            DivisorVentana(ancho, columna, fila+17);
        }

        static bool VentanaAviso(string[] mensajes,int ancho, int alto, int columna, int fila, ConsoleColor colorFondo, bool solicitaConfirmacion=false)
        {
            Console.BackgroundColor = colorFondo;
            DibujarVentana("", ancho, alto, columna, fila);
            Console.ForegroundColor = colorFondo;
            for (int i = 1; i < ancho; i++)
            {
                for (int j = 1; j < alto; j++)
                {
                    Console.SetCursorPosition(columna+i,fila+j);
                    Console.Write("█");
                }
                    
            }
            Console.ForegroundColor = ConsoleColor.White;
            for (int i =0; i < mensajes.Length; i++)
            {
                Console.SetCursorPosition(columna + 5, fila +2 + (i*2));
                Console.Write(mensajes[i]);
            }
            Console.ReadKey(true);
            Console.ResetColor();
            for (int i = 0; i <= ancho; i++)
            {
                for (int j = 0; j <= alto; j++)
                {
                    Console.SetCursorPosition(columna+i,fila+j);
                    Console.Write(" ");
                }
                    
            }
            return false;
        }

        static void VentanaReferencia(int ancho, int alto, int columna, int fila)
        {
            DibujarVentana("Datos de Referencia", ancho, alto, columna, fila);
            MostrarReferencia("Preparado para Plantar", columna + 5, fila + 5, ConsoleColor.DarkGreen);
            MostrarReferencia("Planta Lista Para Cosechar", columna + 5, fila + 7, ConsoleColor.DarkYellow);
            MostrarReferencia("Planta Cosechada", columna + 5, fila + 9, ConsoleColor.Red);
            DivisorVentana(ancho, columna, fila+12);
            Console.SetCursorPosition(columna+(((ancho - "Productos Cosechados".Length)/2)), fila + 13);
            Console.Write("Productos Cosechados");
            DivisorVentana(ancho, columna, fila+14);
            DibujarTabla(productos, ancho-4, 7, columna+2, fila+16);

        }

        static void MostrarProductoElegido(int ancho, int alto, int columna, int fila)
        {
            DibujarVentana("Producto Elegido Para Cosechar", ancho, alto, columna, fila);
            Console.SetCursorPosition(columna + ((ancho-productos[productoActivo].Length)/2), fila + 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(productos[productoActivo]);
            Console.ResetColor();
        }
        
        static void DibujarRecuadro(int columna, int fila)
        {
            Console.SetCursorPosition(columna, fila);
            Console.WriteLine("┌──────┐");
            Console.SetCursorPosition(columna, fila+1);
            Console.WriteLine("│      │");
            Console.SetCursorPosition(columna, fila+2);
            Console.WriteLine("│      │");
            Console.SetCursorPosition(columna, fila+3);
            Console.WriteLine("└──────┘");
        }
            
        static void DibujarParcela(int columna, int fila, int rango)
        {
            for (int contFila = 0; contFila < rango; contFila++)
            {
                for (int contColumna = 0; contColumna < rango; contColumna++)
                {
                    DibujarRecuadro(columna+(contColumna * 9), fila+(contFila*5));
                    Thread.Sleep(tiempoEspera);
                }
            }
        }

        static void PintarRecuadro(int columna, int fila, int rango, int nroCuadro, ConsoleColor color)
        {
            
            int lineaInicial = fila + (((nroCuadro -1)/rango) * 5) + 1;
            int columnaInicial = columna + (((nroCuadro - 1) % rango) * 9) + 1;
            Console.ForegroundColor = color;
            for (int i = 0; i <  6; i++)
            {
                Console.SetCursorPosition(columnaInicial+i, lineaInicial);
                Console.Write("█");
                Console.SetCursorPosition(columnaInicial+i, lineaInicial+1);
                Console.Write("█");
                Thread.Sleep(tiempoEspera);
            }
            
            
        }

        static void PintarParcela(int columna, int fila, int rango, ConsoleColor color)
        {
            for (int i = 1; i <= (rango*rango); i++)
            {
                PintarRecuadro(columna, fila, rango, i, color);
            }
        }

        static void CambiarEstadoParcela(int[,] estadoParcela, int estado)
        {
            for (int i=0; i<rango; i++)
            {
                for (int j = 0; j < rango; j++)
                {
                    estadoParcela[i,j] = estado;
                }
            }
        }

        static void Limpiar(int[,] estadoParcela, int[,] parcela)
        {
            tiempoEspera = 10;
            PintarParcela(columnaInicial, filaInicial, rango, ConsoleColor.Black);
            PintarParcela(columnaInicial, filaInicial, rango, ConsoleColor.DarkGreen);
            CambiarEstadoParcela(estadoParcela, 0);
            CambiarEstadoParcela(parcela, 0);
            string[] mensaje= new string[3];
            mensaje[0]="La parcela se ha Limpiado";
            mensaje[1]="Ya puede plantar nuevamente";
            mensaje[2]="Presiona una tecla para continuar";
            VentanaAviso(mensaje, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkGreen);

        }

        static string[] ValidarPlantacion(string accion)
        {
            if (productoActivo==-1)
            {
                string[] mensajeError = new string[3];
                mensajeError[0]="No se puede plantar la parcela";
                mensajeError[1]="No hay Producto Seleccionado";
                mensajeError[2]="Presiona una tecla para continuar";
                return mensajeError;
            }
            if (accion == "Plantar")
            {
                if (estadoParcela[0,0]==1)
                {
                    string[] mensajeError = new string[3];
                    mensajeError[0]="No se puede plantar la parcela";
                    mensajeError[1]=$"Se encuentran {productos[productoActivo]}s por cosechar";
                    mensajeError[2]="Presiona una tecla para continuar";
                    return mensajeError;
                }
                if (estadoParcela[0,0]==2)
                {
                    string[] mensajeError = new string[3];
                    mensajeError[0]="No se puede plantar la parcela";
                    mensajeError[1]=$"Se han cosechado {productos[productoActivo]}s y no se ha limpiado la parcela";
                    mensajeError[2]="Presiona una tecla para continuar";
                    return mensajeError;
                }
            }
            if (accion == "Cosechar")
            {
               if (estadoParcela[0,0]==0)
                {
                    string[] mensajeError = new string[3];
                    mensajeError[0]="No se puede Cosechar la parcela";
                    mensajeError[1]="No hay Nada Plantado";
                    mensajeError[2]="Presiona una tecla para continuar";
                    return mensajeError;
                }
                if (estadoParcela[0,0]==2)
                {
                    string[] mensajeError = new string[3];
                    mensajeError[0]="No se puede cosechar la parcela";
                    mensajeError[1]=$"Ya Se han cosechado {productos[productoActivo]}s y no se ha vuelto a plantar";
                    mensajeError[2]="Presiona una tecla para continuar";
                    return mensajeError;
                } 
            }
            return [];
        }

        static void Plantar(int[,] estadoParcela, int[,] parcela, int producto)
        {
            tiempoEspera = 50;
            string[] validar = ValidarPlantacion("Plantar");
            if (validar.Length == 0)
            {
                PintarParcela(columnaInicial, filaInicial, rango, ConsoleColor.DarkYellow);
                CambiarEstadoParcela(estadoParcela, 1);
                CambiarEstadoParcela(parcela, producto);
                string[] mensaje= new string[3];
                mensaje[0]=$"La parcela se ha Plantado con {productos[productoActivo]}";
                mensaje[1]="Ya puede Cosechar el Producto";
                mensaje[2]="Presiona una tecla para continuar";
                VentanaAviso(mensaje, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkGreen);
            } else {        
                VentanaAviso(validar, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkRed);
            }
        }

        static void Cosechar(int[,] estadoParcela, int[,] parcela)
        {
            tiempoEspera = 50;
            string [] validar = ValidarPlantacion("Cosechar");
            if (validar.Length == 0)
            {
                PintarParcela(columnaInicial, filaInicial, rango, ConsoleColor.Red);
                CambiarEstadoParcela(estadoParcela, 2);
                cantidadCosechada[productoActivo] = cantidadCosechada[productoActivo] + 27;
                DibujarTabla(productos, 55-4, 7, Console.WindowWidth-58, ((Console.WindowHeight-25)/2+16));
                string[] mensaje= new string[3];
                mensaje[0]=$"Se ha cosechado {productos[productoActivo]}s de la parcela";
                mensaje[1]="Debera limpiar la parcela para poder volver a Plantar";
                mensaje[2]="Presiona una tecla para continuar";
                VentanaAviso(mensaje, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkGreen);
            } else {
                VentanaAviso(validar, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkRed);
            }
        }

        public static int ReadOpcionMenu(string mensaje, ConsoleColor colorTexto, int columna, int fila)
        {
            int value;
            Console.ForegroundColor = colorTexto;
            while (true)
            {   
                Console.SetCursorPosition(columna, fila);
                Console.Write(new string(' ', mensaje.Length + 5));
                Console.SetCursorPosition(columna, fila);
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                } else {
                    string[] mensajeError = new string[3];
                    mensajeError[0]="No se ha ingresado un numero válido";
                    mensajeError[1]="Intente Nuevamente";
                    mensajeError[2]="Presiona una tecla para continuar";
                    VentanaAviso(mensajeError, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkRed);
                }
            }
        }

        static void MostrarTotal(int[] productos)
        {

        }

        public static void Principal()
        {
            /* -------- Codigo Parte Visual -------- */
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.TituloRecuadro("Cosecha", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 60);
            productoActivo = 0;
            VentanaReferencia(55,25,Console.WindowWidth-60, (Console.WindowHeight-25)/2);            
            VentanaMenu(55,25,5, (Console.WindowHeight-25)/2);
            MostrarProductoElegido(50, 6, (Console.WindowWidth-50)/2, 6);

            tiempoEspera = 50;
            DibujarParcela(columnaInicial, filaInicial, rango);
            tiempoEspera = 10;
            PintarParcela(columnaInicial, filaInicial, rango, ConsoleColor.DarkGreen);


            /* ----------- Codigo Logica de Funcionamiento -------- */

            int opcionElegida = -1;
            while (opcionElegida!=0)
            {
                opcionElegida= ReadOpcionMenu("Ingrese la tarea a realizar: ", ConsoleColor.DarkRed, 13, (Console.WindowHeight-25)/2 + 15);
                Action opcionAEjecutar = opcionElegida switch
                {
                    1 => () => Limpiar(estadoParcela, parcela),
                    2 => () => Plantar(estadoParcela, parcela, productoActivo),
                    3 => () => Cosechar(estadoParcela, parcela),
                    4 => () => {},
                    0 => () => {},
                    _ => () => 
                        {
                            string[] mensajeError = new string[3];
                            mensajeError[0]="Opcion del Menu Inválida";
                            mensajeError[1]="Intente Nuevamente";
                            mensajeError[2]="Presiona una tecla para continuar";
                            VentanaAviso(mensajeError, 70, 8, (Console.WindowWidth-70)/2, Console.WindowHeight-15, ConsoleColor.DarkRed);
                        }
                };
                opcionAEjecutar();

            }

            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
            //Funciones.EsperarTeclaFinal();
        }
    }
}