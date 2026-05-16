using System;


namespace Practico_ProgramacionIII
{

	public class POOPolimorfismo
	{

        static NotificadorEmail email = new NotificadorEmail();
        static NotificadorSMS sms = new NotificadorSMS();
        static NotificadorPush push = new NotificadorPush();
        static GestorNotificaciones gestor = new GestorNotificaciones(new List<INotificador>());

        public interface INotificador
        {
            void Enviar(string destinatario, string mensaje);
            int CantidadEnviados { get; }
        }

        public class NotificadorEmail : INotificador
        {
            private int _contador;
            public int CantidadEnviados => _contador;

            public void Enviar(string destinatario, string mensaje)
            {
                int columna = Console.CursorLeft;
                int fila = Console.CursorTop;
                Console.SetCursorPosition(columna, fila);
                Console.WriteLine("Email Enviado");
                Console.SetCursorPosition(columna, fila+2);
                Console.WriteLine($"Destinatario: {destinatario}");
                Console.SetCursorPosition(columna, fila+4);
                Console.WriteLine($"Mensaje: {mensaje}");
                Console.SetCursorPosition(columna, fila+6);
                _contador++;

            }
        }

        public class NotificadorSMS : INotificador
        {
            private int _contador;
            public int CantidadEnviados => _contador;

            public void Enviar(string destinatario, string mensaje)
            {
                int columna = Console.CursorLeft;
                int fila = Console.CursorTop;
                Console.SetCursorPosition(columna, fila);
                Console.WriteLine("SMS Enviado");
                Console.SetCursorPosition(columna, fila+2);
                Console.WriteLine($"Destinatario: {destinatario}");
                Console.SetCursorPosition(columna, fila+4);
                Console.WriteLine($"Mensaje: {mensaje}");
                Console.SetCursorPosition(columna, fila+6);
                _contador++;
            }
        }

        public class NotificadorPush : INotificador
        {
            private int _contador;
            public int CantidadEnviados => _contador;

            public void Enviar(string destinatario, string mensaje)
            {
                int columna = Console.CursorLeft;
                int fila = Console.CursorTop;
                Console.SetCursorPosition(columna, fila);
                Console.WriteLine("Mensaje Push Enviado");
                Console.SetCursorPosition(columna, fila+2);
                Console.WriteLine($"Destinatario: {destinatario}");
                Console.SetCursorPosition(columna, fila+4);
                Console.WriteLine($"Mensaje: {mensaje}");
                Console.SetCursorPosition(columna, fila+6);
                _contador++;
            }
        }

        public class GestorNotificaciones
        {
            private List<INotificador> _listaNotificadores = new List<INotificador>();

            public List<INotificador> ListaNotificadores
            {
                get { return _listaNotificadores; }
                set 
                {
                    if (value !=null && value.Count > 0) { _listaNotificadores = value; }
                }
            }

            public GestorNotificaciones(List<INotificador> listado )
            {
                ListaNotificadores = new List<INotificador>(listado);
            }

            public void NotificarATodos(string destinatario, string mensaje)
            {
                int col = Console.CursorLeft;
                int fila = Console.CursorTop;
                Console.CursorVisible = false;
                foreach (INotificador notificador in ListaNotificadores)
                {
                    Console.SetCursorPosition(col, fila);
                    notificador.Enviar(destinatario, mensaje);
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey(true);
                }
                Console.CursorVisible = true;
            }

            public void ReporteNotificaciones()
            {
                foreach (INotificador notificador in ListaNotificadores)
                {
                    Console.WriteLine($"Notificador: {notificador.GetType().Name} ha enviado {notificador.CantidadEnviados} notificaciones\n\n");
                }
            }
        }


		public static void Principal()
		{
			// Inicializamos el gestor con todos los canales por defecto
            gestor.ListaNotificadores = new List<INotificador> { email, sms, push };

            int opcion = 0;
            do
            {
                Console.Clear();
                Funciones.MostrarTitulo("SISTEMA DE NOTIFICACIONES POLIMÓRFICO", ConsoleColor.Cyan, 0);
                Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);

                MostrarDashboard();

                OpcionMenu[] opciones = new OpcionMenu[]
                {
                    new OpcionMenu { Valor = 1, Titulo = "Notificar por ", TituloColor = "EMAIL" },
                    new OpcionMenu { Valor = 2, Titulo = "Notificar por ", TituloColor = "SMS" },
                    new OpcionMenu { Valor = 3, Titulo = "Notificar por ", TituloColor = "PUSH" },
                    new OpcionMenu { Valor = 4, Titulo = "Notificar por ", TituloColor = "TODOS LOS MEDIOS" },
                    new OpcionMenu { Valor = 0, Titulo = "Salir del ", TituloColor = "SISTEMA" }
                };

                DibujarVentana("Menú de Opciones", 45, 18, 2, 7, ConsoleColor.DarkCyan);
                opcion = Funciones.GenerarMenu(opciones, 4, 12, ConsoleColor.Yellow, ConsoleColor.DarkCyan);

                if (opcion > 0 && opcion < 5)
                {
                    ProcesarEnvio(opcion);
                }
                else if (opcion == 0 || opcion == -1)
                {
                    Funciones.EsperarFinalSistema();
                }

            } while (opcion != 0 && opcion != -1);
        }

        static void MostrarDashboard()
        {
            int col = Console.WindowWidth - 35;
            
            DibujarCajaEstadistica("EMAIL ENVIADOS", email.CantidadEnviados, col, 7, ConsoleColor.DarkGray);
            DibujarCajaEstadistica("SMS ENVIADOS", sms.CantidadEnviados, col, 14, ConsoleColor.DarkGray);
            DibujarCajaEstadistica("PUSH ENVIADOS", push.CantidadEnviados, col, 21, ConsoleColor.DarkGray);

            int total = email.CantidadEnviados + sms.CantidadEnviados + push.CantidadEnviados;
            DibujarCajaEstadistica("TOTAL GENERAL", total, col, 28, ConsoleColor.DarkGray);
        }

        static void DibujarCajaEstadistica(string titulo, int valor, int col, int fila, ConsoleColor color)
        {
            DibujarVentana(titulo, 30, 5, col, fila, color);
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col + 13, fila + 3);
            Console.Write(valor.ToString("D3"));
            Console.ResetColor();
        }

        static void ProcesarEnvio(int seleccion)
        {
            int ancho = 60;
            int col = (Console.WindowWidth-ancho)/2;
            int fila = 9;
            
            DibujarVentana("INGRESE DATOS DE LA NOTIFICACIÓN", ancho, 18, col, fila, ConsoleColor.White);
            DivisorVentana(ancho, col, fila + 8);

            List<INotificador> canal = seleccion switch {
                1 => new List<INotificador> { email },
                2 => new List<INotificador> { sms },
                3 => new List<INotificador> { push },
                4 => new List<INotificador> { email, sms, push },
                _ => null
            };
            gestor.ListaNotificadores = new List<INotificador> (canal) ;

            Console.SetCursorPosition(col + 4, fila + 4);
            string destinatario = Funciones.ReadString("Destinatario: ", 3, 25, ConsoleColor.White, ConsoleColor.Cyan);
            Console.SetCursorPosition(col + 4, fila + 6);
            string mensaje = Funciones.ReadString("Mensaje: ", 1, 45, ConsoleColor.White, ConsoleColor.Cyan);

            Console.SetCursorPosition(col + 4, fila + 10);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            gestor.NotificarATodos(destinatario, mensaje);
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
            Console.SetCursorPosition(columna + ancho, fila);
            Console.Write("┤");
        }

        static void DibujarVentana(string titulo, int ancho, int alto, int columna, int fila, ConsoleColor colorLinea = ConsoleColor.White)
        {
            Console.ForegroundColor = colorLinea;
            for (int i = 1; i <= ancho; i++)
            {
                Console.SetCursorPosition(columna + i, fila);
                Console.Write("─");
                Console.SetCursorPosition(columna + i, fila + alto);
                Console.Write("─");
            }
            for (int i = 1; i <= alto; i++)
            {
                Console.SetCursorPosition(columna, fila + i);
                Console.Write("│");
                Console.SetCursorPosition(columna + ancho, fila + i);
                Console.Write("│");
            }
            Console.SetCursorPosition(columna, fila);
            Console.Write("┌");
            Console.SetCursorPosition(columna + ancho, fila);
            Console.Write("┐");
            Console.SetCursorPosition(columna, fila + alto);
            Console.Write("└");
            Console.SetCursorPosition(columna + ancho, fila + alto);
            Console.Write("┘");
            if (titulo.Length > 0)
            {
                DivisorVentana(ancho, columna, fila + 2);
                Console.SetCursorPosition(columna + (((ancho - titulo.Length) / 2)), fila + 1);
                Console.Write(titulo);
            }
            Console.ResetColor();
        }
	}
}