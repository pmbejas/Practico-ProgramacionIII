namespace Practico_ProgramacionIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionElegida = 0;
            while (opcionElegida != -1)
            {
                Console.Clear();
                Funciones.MostrarTitulo(Globales.pieDePagina, ConsoleColor.DarkGray, Console.WindowHeight-1);
                Funciones.TituloRecuadro("Menu de Programas", 0, Globales.colorTextoRecuadroTitulo, Globales.colorLineasRecuadroTitulo, 50);
                Console.ForegroundColor= Globales.colorTextoMensaje;
                Console.SetCursorPosition(0, 5);
                
                OpcionMenu[] opcionesMenu = new OpcionMenu[]
                {
                    new OpcionMenu { Valor = 0, Titulo = "Program 00: ", TituloColor = "Hola Mundo!!!", Ejecutar = Program00.Principal },
                    new OpcionMenu { Valor = 1, Titulo = "Program 01: ", TituloColor = "Registro y Login de Usuario", Ejecutar = Program01.Principal },
                    new OpcionMenu { Valor = 2, Titulo = "Program 02: ", TituloColor = "Tipos de Datos: int (Entero)", Ejecutar = Program02.Principal },
                    new OpcionMenu { Valor = 3, Titulo = "Program 03: ", TituloColor = "Tipos de Datos: float, double y decimal", Ejecutar = Program03.Principal },
                    new OpcionMenu { Valor = 4, Titulo = "Program 04: ", TituloColor = "Tipos de Datos: string (Cadena de Caracteres)", Ejecutar = Program04.Principal },
                    new OpcionMenu { Valor = 5, Titulo = "Program 05: ", TituloColor = "Tipos de Datos: bool (Booleano)", Ejecutar = Program05.Principal },
                    new OpcionMenu { Valor = 6, Titulo = "Program 06: ", TituloColor = "Constantes", Ejecutar = Program06.Principal },
                    new OpcionMenu { Valor = 7, Titulo = "Program 07: ", TituloColor = "Constantes de Cálculo, control y representación", Ejecutar = Program07.Principal },
                    new OpcionMenu { Valor = 8, Titulo = "Program 08: ", TituloColor = "Matriz Caracol", Ejecutar = Program08.Principal },
                    new OpcionMenu { Valor = 9, Titulo = "Program 09: ", TituloColor = "(En Construccion...)", Ejecutar = Program09.Principal },
                    new OpcionMenu { Valor = 10, Titulo = "Program 10: ", TituloColor = "(En Construccion...)", Ejecutar = Program10.Principal },
                    new OpcionMenu { Valor = 11, Titulo = "Ejercicios Clases Practicas: ", TituloColor = "Propuestas en clase", Ejecutar = EjerciciosClasesPracticas.Principal },
                    new OpcionMenu { Valor = 12, Titulo = "Ejercitacion ", TituloColor = "Practicas Personales", Ejecutar = Ejercitacion.Principal },
                    new OpcionMenu { Valor = -1, Titulo = "Salir", TituloColor = "", Ejecutar = () => { } }
                };
                
                opcionElegida = Funciones.GenerarMenu(opcionesMenu, 5, ConsoleColor.DarkYellow, ConsoleColor.DarkCyan, true);

                if (opcionElegida != -1)
                {
                    Console.Clear();
                    opcionesMenu[opcionElegida].Ejecutar();
                }
                else
                {
                    Funciones.EsperarFinalSistema();
                }
            }

        }
    }
}
