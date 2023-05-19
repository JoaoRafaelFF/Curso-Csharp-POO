using System;
using System.Globalization;


namespace EstruturaRepetitivaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos numeros voce vai digitar para a soma?");

            int N = int.Parse(Console.ReadLine());

            double Soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("digite o " + i + " numero");
                    double Nl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Soma += Nl;
            }

            Console.WriteLine("O Resultado da soma dos numeros é: " + Soma.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
