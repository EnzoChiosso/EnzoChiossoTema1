namespace Actividad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la diagonal mayor del rombo: ");
            double diagonalMayor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la diagonal menor del rombo: ");
            double diagonalMenor = Convert.ToDouble(Console.ReadLine());

            Entidades.Rombo rombo = new Entidades.Rombo(diagonalMayor, diagonalMenor);

            rombo.ImprimirDatos();

        }
    }
}