namespace Actividad_4.Entidades
{
    public struct Rombo
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public Rombo(double diagonalMayor, double diagonalMenor)
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
        }

        public double CalcularLado()
        {
            return Math.Sqrt((Math.Pow(DiagonalMayor, 2) + Math.Pow(DiagonalMenor, 2)) / 2);
        }

        public double CalcularPerimetro()
        {
            return 4 * CalcularLado();
        }

        public double CalcularSuperficie()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Diagonal Mayor: {DiagonalMayor}");
            Console.WriteLine($"Diagonal Menor: {DiagonalMenor}");
            Console.WriteLine($"Lado: {CalcularLado()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
            Console.WriteLine($"Superficie: {CalcularSuperficie()}");
        }
    }
}
