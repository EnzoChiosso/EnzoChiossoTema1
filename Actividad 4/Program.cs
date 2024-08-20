using ConsoleTables;
using System;
using System.Linq;
using System;
using System.Linq;

namespace Actividad_4
{
    class Program
    {
        private static Entidades.Rombo[] rombos;
        private static int index = 0;
        private const int MAX_ROMBO = 10;

        static void Main(string[] args)
        {
            rombos = new Entidades.Rombo[MAX_ROMBO];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar Rombo");
                Console.WriteLine("2. Mostrar Todos los Rombos");
                Console.WriteLine("3. Modificar Rombo");
                Console.WriteLine("4. Mostrar Estadisticas");
                Console.WriteLine("5. Mostrar Rombos con Superficie Superior al Promedio");
                Console.WriteLine("6. Salir");

                Console.Write("Seleccione una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarRombo();
                        break;
                    case 2:
                        MostrarRombos();
                        break;
                    case 3:
                        ModificarRombo();
                        break;
                    case 4:
                        MostrarEstadisticas();
                        break;
                    case 5:
                        MostrarRombosSuperiorPromedio();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opcion no valida, vuelva a intenta");
                        break;
                }
            }
        }

        static void IngresarRombo()
        {
            if (index >= MAX_ROMBO)
            {
                Console.WriteLine("El array de rombos está lleno.");
                return;
            }

            Console.WriteLine("Ingrese la diagonal mayor del rombo:");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la diagonal menor del rombo:");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());

            rombos[index] = new Entidades.Rombo(diagonalMayor, diagonalMenor);
            index++;
        }

        static void MostrarRombos()
        {
            if (index == 0)
            {
                Console.WriteLine("No hay rombos para mostrar");
                return;
            }

            var table = new ConsoleTable("Diagonal Mayor", "Diagonal Menor", "Lado", "Perimetro", "Superficie");

            foreach (var rombo in rombos.Take(index))
            {
                table.AddRow(rombo.DiagonalMayor, rombo.DiagonalMenor, rombo.CalcularLado(), rombo.CalcularPerimetro(), rombo.CalcularSuperficie());
            }
            table.Write();

            Console.ReadLine();
        }

        static void ModificarRombo()
        {
            MostrarRombos();

            Console.WriteLine("Ingrese el índice del rombo que desea modificar (0 a {0}):", index - 1);
            int i = Convert.ToInt32(Console.ReadLine());

            if (i < 0 || i >= index)
            {
                Console.WriteLine("Índice no válido.");
                return;
            }

            Console.WriteLine("Ingrese la nueva diagonal mayor del rombo:");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nueva diagonal menor del rombo:");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());

            rombos[i] = new Entidades.Rombo(diagonalMayor, diagonalMenor);
        }

        static void MostrarEstadisticas()
        {
            if (index == 0)
            {
                Console.WriteLine("No hay rombos para calcular estadísticas.");
                return;
            }

            var superficies = rombos.Take(index).Select(r => r.CalcularSuperficie()).ToList();

            var maxSuperficie = superficies.Max();
            var minSuperficie = superficies.Min();
            var promedioSuperficie = superficies.Average();

            var romboMaxSuperficie = rombos[superficies.IndexOf(maxSuperficie)];
            var romboMinSuperficie = rombos[superficies.IndexOf(minSuperficie)];

            Console.WriteLine($"Rombo con mayor superficie:");
            romboMaxSuperficie.ImprimirDatos();

            Console.WriteLine($"Rombo con menor superficie:");
            romboMinSuperficie.ImprimirDatos();

            Console.WriteLine($"Promedio de superficies: {promedioSuperficie}");
        }

        static void MostrarRombosSuperiorPromedio()
        {
            if (index == 0)
            {
                Console.WriteLine("No hay rombos para calcular el promedio.");
                return;
            }

            var superficies = rombos.Take(index).Select(r => r.CalcularSuperficie()).ToList();
            var promedioSuperficie = superficies.Average();

            var rombosSuperiorPromedio = rombos
                .Take(index)
                .Where(r => r.CalcularSuperficie() > promedioSuperficie)
                .ToList();

            if (!rombosSuperiorPromedio.Any())
            {
                Console.WriteLine("No hay rombos con superficie superior al promedio.");
                return;
            }

            var table = new ConsoleTable("Diagonal Mayor", "Diagonal Menor", "Lado", "Perímetro", "Superficie");

            foreach (var rombo in rombosSuperiorPromedio)
            {
                table.AddRow(rombo.DiagonalMayor, rombo.DiagonalMenor, rombo.CalcularLado(), rombo.CalcularPerimetro(), rombo.CalcularSuperficie());
            }

            table.Write();
        }
    }
}