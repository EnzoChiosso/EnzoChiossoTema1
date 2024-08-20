namespace Actividad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int cantidadRombos = 5;
            double mayorPerimetro = 0;
            int romboMayor = -1;
            double sumaPerimetros = 0;

            for (int i = 1; i <= cantidadRombos; i++)
            {
                double diagonalMayor;
                double diagonalMenor;

                while (true)
                {
                    Console.Write($"Ingrese la diagonal mayor del rombo {i}: ");
                    if (double.TryParse(Console.ReadLine(), out diagonalMayor) && diagonalMayor > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Diagonal mayor no valida");
                }

                while (true)
                {
                    Console.Write($"Ingrese la diagonal menor del rombo {i}: ");
                    if (double.TryParse(Console.ReadLine(), out diagonalMenor) && diagonalMenor > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Diagonal menor no valida");
                }

                double lado = Math.Sqrt((diagonalMayor * diagonalMayor + diagonalMenor * diagonalMenor) / 2);
                double perimetro = 4 * lado;

                if (perimetro > mayorPerimetro)
                {
                    mayorPerimetro = perimetro;
                    romboMayor = i;
                }
                sumaPerimetros += perimetro;
            }

            Console.WriteLine($"El rombo mayor es el rombo {romboMayor} y su perimetro es {mayorPerimetro}.");


            double promedioPerimetros = sumaPerimetros / cantidadRombos;
            Console.WriteLine($"El promedio de los perimetros de los rombos es {promedioPerimetros}");
        }
    }
}
