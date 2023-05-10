using System;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero!");

            int Num = int.Parse(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine(Num + " é par");
            }
            else
            {
                Console.WriteLine(Num + " é impar");
            }
        }
    }
}