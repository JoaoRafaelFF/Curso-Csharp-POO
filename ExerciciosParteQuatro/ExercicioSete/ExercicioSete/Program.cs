using System;

namespace ExercicioSete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro! o valor gerará um numero de linhas o quadrado e o cubo de i");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int linha = i;
                int Quadrado = i * i;
                int Cubo = i * i * i;
                Console.WriteLine("linha: " + i + " Quadrado: " + Quadrado + " Cubo: " + Cubo);
            }
        }
    }
}