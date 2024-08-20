namespace Actividad_3.Entidades
{
    public struct Rombo
    {
        private double diagonalMayor;
        private double diagonalMenor;

        public Rombo(double diagonalMayor, double diagonalMenor)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public void SetDiagonales(double diagonalMayor, double diagonalMenor)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public double GetDiagonalMayor()
        {
            return diagonalMayor;
        }

        public double GetDiagonalMenor()
        {
            return diagonalMenor;
        }

        public double CalcularLado()
        {
            return Math.Sqrt((Math.Pow(diagonalMayor, 2) + Math.Pow(diagonalMenor, 2)) / 2);
        }

        public double CalcularPerimetro()
        {
            return 4 * CalcularLado();
        }

        public double CalcularSuperficie()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Diagonal Mayor: {GetDiagonalMayor()}");
            Console.WriteLine($"Diagonal Menor: {GetDiagonalMenor()}");
            Console.WriteLine($"Lado: {CalcularLado()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
            Console.WriteLine($"Superficie: {CalcularSuperficie()}");
        }
    }
}