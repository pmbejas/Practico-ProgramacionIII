namespace Practico_ProgramacionIII
{
    public class OpcionMenu
    {
        public int Valor { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string TituloColor { get; set; } = string.Empty;
        public Action Ejecutar { get; set; } = () => { };
    }

    public class VariablesGlobales
        {
            public static string pieDePagina = "Programación III (Práctica) - Profesor: Rodrigo Esper - Alumno: Pablo Bejas";
            public static ConsoleColor colorTextoMensaje = ConsoleColor.White;
            public static ConsoleColor colorTextoTitulo = ConsoleColor.DarkYellow;
            public static ConsoleColor colorTextoVineta = ConsoleColor.DarkRed;
            public static ConsoleColor colorTextoMenu = ConsoleColor.DarkCyan;
        }
}