using System;

namespace ExercicioCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para ver ser fatorial!");

            int N = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= N; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}
