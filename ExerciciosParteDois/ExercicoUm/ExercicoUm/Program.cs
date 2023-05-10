using System;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");

            int Num = int.Parse(Console.ReadLine());

            if(Num < 0)
            {
                Console.WriteLine("Numero negativo!");
            }
            else
                Console.WriteLine("Numero não negativo!");
        }
    }
}
