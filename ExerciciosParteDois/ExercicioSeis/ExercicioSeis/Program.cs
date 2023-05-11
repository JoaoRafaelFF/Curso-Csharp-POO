using System;
using System.Globalization;

namespace ExercicioSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor com ponto!");

            double Num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (Num < 0.0 || Num > 100.0)
            {
                Console.WriteLine("Valor Fora do intervalo!");
            }
            else if (Num <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (Num <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (Num <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}