using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico_ProgramacionIII
{
    public class Program05
    {
        internal static void Ejercicio1 ()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos BOOLEAN", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 1:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine("Solicitá usuario y contraseña.");            
            Console.WriteLine("Definí valores correctos (por ejemplo: \"admin\" y \"1234\").");
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Determiná si el login es válido:");
            Funciones.TextoEnColor(" b. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("El acceso es correcto solo si usuario Y contraseña coinciden.");
            Funciones.TextoEnColor(" c. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Si el usuario es correcto pero la contraseña no coincide,");
            Console.WriteLine("    el mensaje debe indicar que la contraseña es incorrecta.");
            
            string usuarioCorrecto = "pablo";
            string contrasenaCorrecta = "pablo1234";
            
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine("\n");
            Console.WriteLine("+-------------------------------------------------+");
            Console.WriteLine("|     Ingrese sus datos para iniciar sesión       |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("+-------------------------------------------------+");
            Console.SetCursorPosition(6, 19);
            string userIngresado = Funciones.ReadString("Usuario: ", 1, 25, Program.VariablesGlobales.colorTextoMensaje, ConsoleColor.DarkCyan, false);
            Console.SetCursorPosition(6, 21);
            string userPasswordIngresado = Funciones.ReadPassword("Contraseña: ", Program.VariablesGlobales.colorTextoMensaje, ConsoleColor.DarkCyan);

            bool usuarioEsCorrecto = userIngresado == usuarioCorrecto;
            bool contrasenaEsCorrecta = userPasswordIngresado == contrasenaCorrecta;

            bool accesoConcedido = usuarioEsCorrecto && contrasenaEsCorrecta;
            
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            ConsoleColor colorMensajeResultado = accesoConcedido ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
            Console.ForegroundColor = colorMensajeResultado;
            Console.WriteLine($"Acceso al sistema: {accesoConcedido}");

            string mensajeAdicional = (usuarioEsCorrecto && !contrasenaEsCorrecta) ? "La contraseña es incorrecta." : string.Empty;
            Console.ForegroundColor = colorMensajeResultado;
            Console.WriteLine();
            Console.WriteLine(mensajeAdicional);

            Funciones.EsperarTeclaFinal();
        }

        internal static void Ejercicio2 ()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos BOOLEAN", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 2:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine("Pedí tres notas (números enteros).");            
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Determiná si el alumno aprueba:");
            Console.WriteLine("    Aprueba si todas las notas son mayores o iguales a 6.");
            Console.WriteLine("    Mostrá un bool.");   
            
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine();
            int nota1 = Funciones.ReadInteger("Ingrese la primera nota: ", Program.VariablesGlobales.colorTextoMensaje);
            int nota2 = Funciones.ReadInteger("Ingrese la segunda nota: ", Program.VariablesGlobales.colorTextoMensaje);
            int nota3 = Funciones.ReadInteger("Ingrese la tercera nota: ", Program.VariablesGlobales.colorTextoMensaje);

            bool aprueba = nota1 >= 6 && nota2 >= 6 && nota3 >= 6;
            
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            
            ConsoleColor colorResultado = aprueba ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.Write($"El alumno aprueba: ");
            Funciones.TextoEnColor(aprueba.ToString(), colorResultado, Program.VariablesGlobales.colorTextoMensaje);
            Funciones.EsperarTeclaFinal();
        }

        internal static void Ejercicio3 ()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos BOOLEAN", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 3:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine("Pedí al usuario que ingrese un numero entero.");            
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Determiná si está dentro de un rango válido:");
            Console.WriteLine("    El número debe ser mayor que 10 Y menor que 50.");
            Console.WriteLine("    Mostrá el resultado como booleano.");   
            
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine();
            
            int numeroIngresado = Funciones.ReadInteger("Ingrese un número entero: ", Program.VariablesGlobales.colorTextoMensaje);
            
            bool estaDentroDelRango = numeroIngresado > 10 && numeroIngresado < 50;
            
            Console.WriteLine();
            Console.Write("El número está dentro del rango válido: ");
            Funciones.TextoEnColor(estaDentroDelRango.ToString(), estaDentroDelRango ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed, Program.VariablesGlobales.colorTextoMensaje);
            Funciones.EsperarTeclaFinal();
        }

        internal static void Ejercicio4 ()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos BOOLEAN", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 4:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;


            Console.WriteLine("Pedí al usuario su edad y si tiene documento (responde 'si' o 'no').");            
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Determiná si puede ingresar a un evento:");
            Console.WriteLine("    Solo puede entrar si es mayor o igual a 18 Y tiene documento.");
            Console.WriteLine("    Mostrá el resultado como true o false.");  

            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine();

            int edad = Funciones.ReadInteger("Ingrese su edad: ", Program.VariablesGlobales.colorTextoMensaje);
            string tieneDocumento = Funciones.ReadString("¿Tiene documento? (si/no): ", 1, 3, Program.VariablesGlobales.colorTextoMensaje, ConsoleColor.DarkCyan, false);
            bool respuestaDocumento = tieneDocumento.ToUpper() == "SI" || tieneDocumento.ToUpper() == "S" || tieneDocumento.ToUpper() == "YES" || tieneDocumento.ToUpper() == "Y";

            bool puedeIngresar = edad >= 18 && respuestaDocumento;

            Console.WriteLine();
            Console.Write("Puede ingresar al evento: ");
            Funciones.TextoEnColor(puedeIngresar.ToString(), puedeIngresar ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed, Program.VariablesGlobales.colorTextoMensaje);
            Funciones.EsperarTeclaFinal();
        }

        internal static void Ejercicio5 ()
        {
            Console.Clear();
            Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight - 1);
            Funciones.MostrarTitulo("Tipo de Datos BOOLEAN", ConsoleColor.DarkBlue, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejercicio Nro. 5:");
            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;

            Console.WriteLine("Preguntá al usuario su edad y si está acompañado por un adulto (responde 'si' o 'no').");            
            Funciones.TextoEnColor(" a. ", Program.VariablesGlobales.colorTextoVineta, Program.VariablesGlobales.colorTextoMensaje);
            Console.WriteLine("Determiná si puede ver una película:");
            Console.WriteLine("    Puede verla si es mayor o igual a 16 O está acompañado.");
            Console.WriteLine("    Mostrá el resultado como true o false.");  
            
                        Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
            Console.WriteLine("Ejecución:");
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.WriteLine();

            int edad = Funciones.ReadInteger("Ingrese su edad: ", Program.VariablesGlobales.colorTextoMensaje);
            string estaAcompanado = Funciones.ReadString("¿Está acompañado por un adulto? (si/no): ", 1, 3, Program.VariablesGlobales.colorTextoMensaje, ConsoleColor.DarkCyan, false);
            bool respuestaAcompanado = estaAcompanado.ToUpper() == "SI" || estaAcompanado.ToUpper() == "S" || estaAcompanado.ToUpper() == "YES" || estaAcompanado.ToUpper() == "Y";

            bool puedeVerPelicula = edad >= 16 || respuestaAcompanado;

            Console.WriteLine();
            Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
            Console.Write("Puede ver la película: ");
            Funciones.TextoEnColor(puedeVerPelicula.ToString(), puedeVerPelicula ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed, Program.VariablesGlobales.colorTextoMensaje);
            Funciones.EsperarTeclaFinal();
        }

        public static void Principal()
        {

            Console.Clear();
            int opcionElegida = -1;
            while (opcionElegida != 0)
            {
                Console.Clear();
                Funciones.MostrarTitulo(Program.VariablesGlobales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight-1);
                Funciones.MostrarTitulo("Tipo de Datos BOOLEAN", ConsoleColor.DarkBlue, 0);

                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Que son BOOLEANOS en C#");
                Console.WriteLine("");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine("El tipo de dato bool se utiliza para almacenar valores de verdad (true o false).");
                Console.WriteLine("Comunmente se utiliza para representar condiciones, estados o resultados de comparaciones.");
                
                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Forma de Uso");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine("Para declarar una variable de este tipo, al igual que con cualquier otro tipo de dato, simplemente usas");
                Console.Write("la palabra clave ");
                Funciones.TextoEnColor("bool", ConsoleColor.Cyan, ConsoleColor.White);
                Console.WriteLine(" seguida del nombre que quieras darle a la variable.");
                Console.WriteLine();

                Console.WriteLine();
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Ejercitación:");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine("A continuación se presentan una serie de ejercicios para practicar");
                Console.WriteLine("el uso de variables booleanas y operadores lógicos.");

                Console.WriteLine("\n");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoTitulo;
                Console.WriteLine("Menu de Opciones:");
                Console.ForegroundColor = Program.VariablesGlobales.colorTextoMensaje;
                Console.WriteLine();
                Console.WriteLine("  1. Ejercicio 1");
                Console.WriteLine("  2. Ejercicio 2");
                Console.WriteLine("  3. Ejercicio 3");
                Console.WriteLine("  4. Ejercicio 4");
                Console.WriteLine("  5. Ejercicio 5");
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("  0. Salir");
                Console.WriteLine();
                opcionElegida = Funciones.ReadInteger("Ejercicio a ejecutar?: ", ConsoleColor.DarkGreen);

                Action ejercicioAEjecutar = opcionElegida switch
                {
                    1 => Ejercicio1,
                    2 => Ejercicio2,
                    3 => Ejercicio3,
                    4 => Ejercicio4,
                    5 => Ejercicio5,
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
