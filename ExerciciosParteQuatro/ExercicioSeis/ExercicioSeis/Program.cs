using System;

namespace ExercicioSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para descobrir seus divizores! ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i+" é divisor de "+ N);
                }
            }
        }
    }
}
