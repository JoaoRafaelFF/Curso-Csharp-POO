using System;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber quantos impares tem do numero até 1 ");

            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}