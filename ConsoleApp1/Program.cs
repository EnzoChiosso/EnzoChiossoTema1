namespace EnzoChiossoTema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de la diagonal menor: ");
            if (!int.TryParse(Console.ReadLine(), out int diagonalMenor))
            {
                Console.WriteLine("Diagonal mal ingresada");
                return;
            }
            Console.Write("Ingrese el valor de la diagonal mayor: ");
            if (!int.TryParse(Console.ReadLine(), out int diagonalMayor))
            {
                Console.WriteLine("Diagonal mal ingresada");
                return;
            }
            double lado = Math.Sqrt((Math.Pow(diagonalMayor / 2, 2) + Math.Pow(diagonalMenor / 2, 2)));
            double perimetro = lado * 4;
            double superficie = (diagonalMayor * diagonalMenor) / 2;

            Console.WriteLine($"El lado del rombo es: {lado}");
            Console.WriteLine($"El perimetro del rombo es: {perimetro}");
            Console.WriteLine($"La superficie del rombo es: {superficie}");
        }
    }
}