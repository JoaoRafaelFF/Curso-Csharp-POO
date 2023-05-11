using System;
using System.Globalization;

namespace ExercicioOito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salatio para saber o imposto cobrado!");

            double Sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Imposto;

            if (Sal <= 2000.00)
            {
                Imposto = 0.0;
            }
            else if (Sal <= 3000.00)
            {
                Imposto = (Sal - 2000.0) * 0.08;
            }
            else if (Sal <= 4500.00)
            {
                Imposto = (Sal - 3000.00) * 0.18 + 1000 * 0.08;
            }
            else
            {
                Imposto = (Sal - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (Imposto == 0.0)
            {
                Console.WriteLine("Isento de imposto");
            }
            else
            {
                Console.WriteLine("O imposto é de R$ " + Imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}