using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Practico_ProgramacionIII
{
    public class ObjetosEncapsulamiento
    {
        public static CuentaBancaria cuentaCliente = new CuentaBancaria(CuentaBancaria.Tipos.Ahorro);

        public class CuentaBancaria {

            private double _saldo;
            public enum Tipos { Ahorro, Corriente };
            private Tipos _tipoCuenta;
            private List<Transacciones> _historialTransacciones = new List<Transacciones>();
            
            public IReadOnlyList<Transacciones> HistorialTransacciones => _historialTransacciones;

            public CuentaBancaria(Tipos tipo)
            {
                _saldo = 0;
                _tipoCuenta = tipo;
            }

            public class Transacciones
            {
                private static int _autoIncrement = 0;
                
                private int _idTransaccion { get; }
                private int _codigoTransaccion { get; }
                private double _importe { get; }
                private DateTime _fechaTransaccion { get; }
                
                public Transacciones(int codigo, double importe)
                {
                    _autoIncrement++;
                    _idTransaccion = _autoIncrement;
                    _codigoTransaccion = codigo;
                    _importe = importe;
                    _fechaTransaccion = DateTime.Now;
                }
                
                public int IdTransaccion
                {
                    get { return _idTransaccion; }
                }


                public int CodigoTransaccion
                {
                    get { return _codigoTransaccion; }
                }
                
                public double Importe
                {
                    get { return _importe; }
                }

                public DateTime FechaTransaccion
                {
                    get { return _fechaTransaccion; }
                }
            }
            
            public double Saldo
            {
                get { return _saldo; }
                private set { _saldo = value; }
            }

            public Tipos TipoCuenta
            {
                get { return _tipoCuenta; }
                private set { _tipoCuenta = value; }
            }
            
            public string RealizarExtraccion(double importe)
            {
                if (importe <= 0 )
                {
                    return "El importe a Extraer debe ser mayor a 0";
                }
                if (importe > Saldo)
                {
                    return "No posee saldo suficiente para retirar";
                }
                _saldo -= importe;
                _historialTransacciones.Add(new Transacciones(2, importe));
                return "Operación Exitosa";
            }
            
            public string RealizarDeposito(double importe)
            {
                if (importe <= 0 )
                {
                    return "El importe a Depositar debe ser mayor a 0";
                }
                _saldo += importe;
                _historialTransacciones.Add(new Transacciones(1, importe));
                return "Operación Exitosa";
            }       
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

        public static void MostrarDash()
        {
            DibujarVentana("Saldo Actual", 25, 7, Console.WindowWidth-32, 19);
            Console.ForegroundColor = ConsoleColor.Green;
            string mostrarSaldo = $"$ {cuentaCliente.Saldo}";
            Console.SetCursorPosition(Console.WindowWidth-25, 23);
            Console.WriteLine("               ");
            Console.SetCursorPosition(Console.WindowWidth-10-mostrarSaldo.Length, 23);
            Console.WriteLine(mostrarSaldo);

            DibujarVentana("Tipo Cuenta", 25, 7, Console.WindowWidth-65, 19);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string mostrarTipo = $"{cuentaCliente.TipoCuenta}";
            Console.SetCursorPosition(Console.WindowWidth-45-mostrarTipo.Length, 23);
            Console.WriteLine(mostrarTipo);

            DibujarVentana("Cantidad de Movimientos", 25, 7, Console.WindowWidth-32, 28);
            Console.ForegroundColor = ConsoleColor.Green;
            string mostrarCantidad = $"{cuentaCliente.HistorialTransacciones.Count}";
            Console.SetCursorPosition(Console.WindowWidth-10-mostrarCantidad.Length, 32);
            Console.WriteLine(mostrarCantidad);

            double totalDepositos = 0;
            double totalExtraccion = 0;
            foreach (var transaccion in cuentaCliente.HistorialTransacciones)
            {
                if (transaccion.CodigoTransaccion == 1)
                {
                    totalDepositos += transaccion.Importe;
                }
                else
                {
                    totalExtraccion += transaccion.Importe;
                }
            }

            DibujarVentana("total Depositos", 25, 7, Console.WindowWidth-32, 36);
            Console.ForegroundColor = ConsoleColor.Green;
            string mostrarDepositos = $"$ {totalDepositos}";
            Console.SetCursorPosition(Console.WindowWidth-25, 41);
            Console.WriteLine("               ");
            Console.SetCursorPosition(Console.WindowWidth-10-mostrarDepositos.Length, 41);
            Console.WriteLine(mostrarDepositos);

            DibujarVentana("Total Extracciones", 25, 7, Console.WindowWidth-65, 36);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string mostrarExtracciones = $"$ {totalExtraccion}";
            Console.SetCursorPosition(Console.WindowWidth-55, 41);
            Console.WriteLine("               ");
            Console.SetCursorPosition(Console.WindowWidth-45-mostrarExtracciones.Length, 41);
            Console.WriteLine(mostrarExtracciones);

        }

        public static void Depositar()
        {
            double importeDeposito = 0;
            string mensajeIngreso = "Ingrese Importe: ";
            DibujarVentana("Depósito", 40, 7, (Console.WindowWidth-40)/2, 35);
            Console.SetCursorPosition(((Console.WindowWidth-mensajeIngreso.Length)/2)-5, 39);
            importeDeposito = Funciones.ReadDouble(mensajeIngreso, ConsoleColor.DarkGreen);
            string resultado = cuentaCliente.RealizarDeposito(importeDeposito);
            if (resultado == "Operación Exitosa")
            {
                string[] mensajeResultado = new string[3];
                mensajeResultado[0] = "Operacion Exitosa";
                mensajeResultado[1] = $"Se ha ingresado $ {importeDeposito} a su cuenta";
                mensajeResultado[2] = "Presione cualquier tecla para continuar";
                VentanaAviso(mensajeResultado,50, 8, (Console.WindowWidth-50)/2, 34, ConsoleColor.DarkGreen);
            } 
            else
            {
                string[] mensajeResultado = new string[3];
                mensajeResultado[0] = "Error en la Operación";
                mensajeResultado[1] = resultado;
                mensajeResultado[2] = "Presione cualquier tecla para continuar";
                VentanaAviso(mensajeResultado, 50, 8, (Console.WindowWidth-50)/2, 34, ConsoleColor.Red);
            }
            MostrarDash();
        }

        public static void Extraer()
        {
            double importeExtraccion = 0;
            string mensajeIngreso = "Ingrese Importe: ";
            DibujarVentana("Extracción", 40, 7, (Console.WindowWidth-40)/2, 35);
            Console.SetCursorPosition(((Console.WindowWidth-mensajeIngreso.Length)/2)-5, 39);
            importeExtraccion = Funciones.ReadDouble(mensajeIngreso, ConsoleColor.DarkGreen);
            string resultado = cuentaCliente.RealizarExtraccion(importeExtraccion);
            if (resultado == "Operación Exitosa")
            {
                string[] mensajeResultado = new string[3];
                mensajeResultado[0] = "Operacion Exitosa";
                mensajeResultado[1] = $"Se han Retirado $ {importeExtraccion} de su cuenta";
                mensajeResultado[2] = "Presione cualquier tecla para continuar";
                VentanaAviso(mensajeResultado,50, 8, (Console.WindowWidth-50)/2, 34, ConsoleColor.DarkGreen);
            } 
            else
            {
                string[] mensajeResultado = new string[3];
                mensajeResultado[0] = "Error en la Operación";
                mensajeResultado[1] = resultado;
                mensajeResultado[2] = "Presione cualquier tecla para continuar";
                VentanaAviso(mensajeResultado, 50, 8, (Console.WindowWidth-50)/2, 34, ConsoleColor.Red);
            }
            MostrarDash();
        }

        public static void MostrarTransacciones()
        {
            int columna = (Console.WindowWidth-70)/2;
            int fila = 19;
            DibujarVentana("Listado de Movimientos", 70, 24, columna, fila);

            int filaInicial = 23;
            foreach (var operacion in cuentaCliente.HistorialTransacciones)
            {
                string detalleTransaccion = operacion.CodigoTransaccion == 1 ? "Depósito" : "Extracción";
                Console.ForegroundColor = operacion.CodigoTransaccion == 1 ? ConsoleColor.Blue : ConsoleColor.Red;
                string transaccionCompleta = $"Id: {operacion.IdTransaccion} - {operacion.FechaTransaccion} - {detalleTransaccion} - $ {operacion.Importe}"; 
                Console.SetCursorPosition((Console.WindowWidth/2)-25, filaInicial);
                Console.WriteLine(transaccionCompleta);
                filaInicial++;
            }
            
            string mensajePresionar = "Presione una Tecla para Continuar";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(((Console.WindowWidth-mensajePresionar.Length)/2), fila+22);
            Console.Write(mensajePresionar);
            Console.ReadKey(true);

            for (int i = 0; i <= 70; i++)
            {
                for (int j = 0; j <= 24; j++)
                {
                    Console.SetCursorPosition(columna+i,fila+j);
                    Console.Write(" ");
                }
                    
            }
        }

        public static void ConsultarTransaccion()
        {
            int columna = (Console.WindowWidth-70)/2;
            int fila = 19;
            DibujarVentana("Consultar Transaccion", 70, 24, columna, fila);

            
            string mensajePresionar = "Presione una Tecla para Continuar";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(((Console.WindowWidth-mensajePresionar.Length)/2), fila+22);
            Console.Write(mensajePresionar);
            Console.ReadKey(true);

            for (int i = 0; i <= 70; i++)
            {
                for (int j = 0; j <= 24; j++)
                {
                    Console.SetCursorPosition(columna+i,fila+j);
                    Console.Write(" ");
                }
                    
            }
        }
        public static void ListarMovimientos()
        {
            Console.WriteLine("Listado");
        }

        public static void Principal()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight-1);
            Funciones.MostrarTitulo("POO ENCAPSULAMIENTO", ConsoleColor.DarkBlue, 0);

            Console.WriteLine();
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("      Sistema Bancario");
            Console.WriteLine("");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.WriteLine("      Diseñá una clase CuentaBancaria que proteja el saldo de modificaciones directas. El objetivo es aplicar correctamente el");
            Console.WriteLine("      principio de encapsulamiento para garantizar que el estado interno del objeto solo pueda modificarse a través de métodos controlados.");
            
            Console.WriteLine("      El sistema debe:");
            Console.WriteLine("       → Permitir depositar y retirar dinero con validaciones (monto mayor a cero, saldo suficiente).");
            Console.WriteLine("       → Registrar un historial de transacciones que no pueda ser modificado desde fuera de la clase.");
            Console.WriteLine("       → Calcular interés mensual según el tipo de cuenta: Ahorro = 3%, Corriente = 0%.");
            Console.WriteLine("       → Impedir saldos negativos y depósitos de montos menores o iguales a cero.");
            Console.WriteLine("       → Exponer únicamente lo necesario al exterior mediante propiedades de solo lectura.");
            Console.WriteLine("       → El historial debe estar disponible como IReadOnlyList<string>.");
            
            DibujarVentana("Sistema Bancario", Console.WindowWidth-10, 30, 5, 15);
            
            MostrarDash();

            Console.SetCursorPosition(7,20);
            Console.ForegroundColor = Globales.colorTextoTitulo;
            Console.WriteLine("Menu de Opciones:");
            Console.ForegroundColor = Globales.colorTextoMensaje;
            Console.SetCursorPosition(7,22);
            Console.Write("  1. Realizar Depósito ");
            Funciones.TextoEnColor("(Ingreso de Dinero)", ConsoleColor.DarkCyan, ConsoleColor.White);
            Console.SetCursorPosition(7,24);
            Console.Write("  2. Realizar Extracción ");
            Funciones.TextoEnColor("(Retiro de Dinero)", ConsoleColor.DarkCyan, ConsoleColor.White);
            Console.SetCursorPosition(7,26);
            Console.Write("  3. Consultar Movimientos ");
            Funciones.TextoEnColor("(Transacciones Realizadas)", ConsoleColor.DarkCyan, ConsoleColor.White);
            Console.SetCursorPosition(7,28);
            Console.Write("  4. Consultar una transacción ");
            Funciones.TextoEnColor("(Por su ID)", ConsoleColor.DarkCyan, ConsoleColor.White);
            Console.SetCursorPosition(7,30);
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("  0. Salir");
            int filaOpcion = Console.CursorTop;
            int opcionElegida = -1;

            while (opcionElegida != 0)
            {
                Console.SetCursorPosition(7, filaOpcion + 2);
                Console.Write("                       ");
                Console.SetCursorPosition(7, filaOpcion + 2);
                opcionElegida = Funciones.ReadInteger("Elija Opción?: ", ConsoleColor.DarkGreen);

                Action opcionAEjecutar = opcionElegida switch
                {
                    1 => () => Depositar(),
                    2 => () => Extraer(),
                    3 => () => MostrarTransacciones(),
                    4 => () => ConsultarTransaccion(),
                    0 => () => { },
                    _ => () => 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opción no válida. Selecciona una opción del menú.");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                };

                opcionAEjecutar();
            }
        }
    }
}
    