using System;
using System.Globalization;

namespace ExercicioCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do produto e a quantidade: ");

            string[] Vals = Console.ReadLine().Split(" ");
            int Cod = int.Parse(Vals[0]);
            int Quant = int.Parse(Vals[1]);

            double Total;

            if (Cod == 1)
            {
                Total = Quant * 4.0;
            }
            else if (Cod == 2)
            {
                Total = Quant * 4.5;
            }
            else if (Cod == 3)
            {
                Total = Quant * 5.0;
            }
            else if (Cod == 4)
            {
                Total = Quant * 2.0;
            }
            else
            {
                Total = Quant * 1.5;
            }

            Console.WriteLine("O Total: R$"+Total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}