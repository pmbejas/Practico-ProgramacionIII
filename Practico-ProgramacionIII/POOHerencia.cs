using System;


namespace Practico_ProgramacionIII
{

	public class POOHerencia
	{
		public abstract class Empleado
		{
			private string _apellido;
			private string _nombre;
			private int _legajo;
			private double _sueldoBase;

			// Definicion de Propiedades
			public string Apellido
			{
				get { return _apellido; }
				private set { _apellido = value; }
			}

			public string Nombre
			{
				get { return _nombre; }
				private set { _nombre = value; }
			}
			
			public int Legajo
			{
				get { return _legajo; }
				private set { _legajo = value; }
			}
			
			public double SueldoBase
			{
				get { return _sueldoBase; }
				private set { _sueldoBase = value; }
			}
			
			// Constructores (Sobrecarga)
			public Empleado (string apellido, string nombre, int legajo, double sueldoBase)
			{
				Apellido = apellido;
				Nombre = nombre;
				Legajo = legajo;
				SueldoBase = sueldoBase;
			}

			public Empleado (string apellido, string nombre, int legajo)
			{
				Apellido = apellido;
				Nombre = nombre;
				Legajo = legajo;
				SueldoBase = 0;
			}
			
			public virtual double CalcularSueldo()
			{
				return SueldoBase;
			}

			public virtual void MostrarInfo(int columna, int fila)
			{
				Console.SetCursorPosition(columna, fila);
				Console.WriteLine ($"{Apellido}, {Nombre}");
			}
		}

		public class EmpleadoTiempoCompleto : Empleado
		{
			private double _bono;

			public double Bono
			{
				get { return _bono; }
				private set { _bono = value; }
			}

			public EmpleadoTiempoCompleto(string apellido, string nombre, int legajo, double sueldoBase, int bono) 
										: base(apellido, nombre, legajo, sueldoBase)
			{
				Bono = bono;
			}

			public override double CalcularSueldo()
			{
				return base.CalcularSueldo() + (Bono / 12);
			}

			public override void MostrarInfo(int columna, int fila)
			{
				base.MostrarInfo(columna, fila);
				Console.SetCursorPosition(columna, fila + 1);
				Console.WriteLine ("Modalidad: Tiempo Completo");
				Console.SetCursorPosition(columna, fila + 2 );
				Console.WriteLine ($"Bono Total: $ {Bono:N2} - Bono Mensual: {(Bono / 12):N2}");
				Console.SetCursorPosition(columna, fila + 3 );
				Console.WriteLine ($"Sueldo Base: $ {SueldoBase:N2}");
				Console.SetCursorPosition(columna, fila + 4 );
				Console.WriteLine ($"Sueldo Mensual: $ {CalcularSueldo():N2}");
			}
		}

		public class EmpleadoPartTime : Empleado
		{
			private int _horas;
			private double _importeHoras;

			public int Horas
			{
				get { return _horas; }
				private set { _horas = value; }
			}

			public double ImporteHoras
			{
				get { return _importeHoras; }
				private set { _importeHoras = value; }
			}

			public EmpleadoPartTime(string apellido, string nombre, int legajo, int horas, double importeHoras ) 
									: base(apellido, nombre, legajo)
			{
				Horas = horas;
				ImporteHoras = importeHoras;
			}

			public override double CalcularSueldo()
			{
				return Horas * ImporteHoras;
			}

			public override void MostrarInfo(int columna, int fila)
			{
				base.MostrarInfo(columna, fila);
				Console.SetCursorPosition(columna, fila + 1);
				Console.WriteLine ("Modalidad: Part Time");
				Console.SetCursorPosition(columna, fila +2 );
				Console.WriteLine ($"Horas Asignadas: {Horas} - Precio por Hora: $ {ImporteHoras:N2}");
				Console.SetCursorPosition(columna, fila +3 );
				Console.WriteLine ($"Sueldo Mensual: $ {CalcularSueldo():N2}");
			}
		}

		public class EmpleadoContratado : Empleado
		{
			private DateTime _vencimiento;

			public DateTime Vencimiento
			{
				get { return _vencimiento; }
				private set { _vencimiento = value; }
			}

			public EmpleadoContratado(string apellido, string nombre, int legajo, double sueldoBase, DateTime vencimiento) 
									: base(apellido, nombre, legajo, sueldoBase)
			{
				Vencimiento = vencimiento;
			}

			public int CalcularVencimientoDias()
			{
				TimeSpan dias = Vencimiento - DateTime.Now;
				return dias.Days;
			}

			public override void MostrarInfo(int columna, int fila)
			{
				base.MostrarInfo(columna, fila);
				Console.SetCursorPosition(columna, fila+1);
				Console.WriteLine ("Modalidad: Contratado");
				Console.SetCursorPosition(columna, fila +2 );
				Console.WriteLine ($"Vencimiento del Contrato: {Vencimiento.ToString("dd/MM/yy")} - Dias Restantes: {CalcularVencimientoDias()}");
				Console.SetCursorPosition(columna, fila +3 );
				Console.WriteLine ($"Sueldo: $ {CalcularSueldo():N2}");
			}
		}

		public static void Seed(List<Empleado> lista)
		{
			Random rand = new Random();
			
			// Listas de datos para generar nombres aleatorios
			string[] nombres = { "Juan", "Maria", "Pedro", "Ana", "Luis", "Carla", "Diego", "Elena" };
			string[] apellidos = { "Gomez", "Rodriguez", "Perez", "Lopez", "Garcia", "Martinez", "Sosa", "Fernandez" };

			for (int i = 1; i <= 35; i++)
			{
				string n = nombres[rand.Next(nombres.Length)];
				string a = apellidos[rand.Next(apellidos.Length)];
				int legajo = 1000 + i; // Genera legajos 1001, 1002, etc.

				// Repartimos entre los 3 tipos usando el resto de la división (%)
				int tipo = i % 3;

				if (tipo == 0)
				{
					// Empleado Tiempo Completo
					double sueldo = rand.Next(80000, 150000);
					int bono = 50000;
					AddEmpleado(lista, new EmpleadoTiempoCompleto(a, n, legajo, sueldo, bono));
				}
				else if (tipo == 1)
				{
					// Empleado Part Time
					int horas = rand.Next(40, 100);
					double valorHora = rand.Next(1500, 3000);
					AddEmpleado(lista, new EmpleadoPartTime(a, n, legajo, horas, valorHora));
				}
				else
				{
					// Empleado Contratado
					double sueldo = rand.Next(70000, 120000);
					// Fecha de vencimiento aleatoria entre 30 y 365 días a futuro
					DateTime vencimiento = DateTime.Now.AddDays(rand.Next(30, 365));
					AddEmpleado(lista, new EmpleadoContratado(a, n, legajo, sueldo, vencimiento));
				}
			}
		}

		public static void AddEmpleado(List<Empleado> lista, Empleado empleado)
		{
			if (!lista.Contains(empleado))
			{
				lista.Add(empleado);
			}
		}

		public static void Principal()
		{
			List<Empleado> nomina = new List<Empleado>();
			Seed(nomina);
			Console.Clear();
			int columna = 5;
			int fila = 3;
			int contador = 1;
			foreach (Empleado empleado in nomina)
			{

				Console.WriteLine();
				empleado.MostrarInfo(columna, fila);
				Console.WriteLine();
				if (fila>35)
				{
					Console.Write("\nPresione una Tecla para pasar a la siguiente pagina");
					Console.ReadKey(true);
					fila = 5;
					contador = 1;
					Console.Clear();
				} else 
				{ 
					fila += 6;
					contador++;
				}
				
			}

			double totalSueldos = nomina.Sum(empleado => empleado.CalcularSueldo());
			Console.WriteLine($"\n\nTotal de Sueldos en Nómina: $ {totalSueldos:N2}");
			Console.ReadKey(true);
		}
	}
}