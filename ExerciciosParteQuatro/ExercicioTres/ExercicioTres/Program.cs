using System;
using System.Globalization;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de entradas a serem feitas");

            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("digite os 3 valores decimais:");

            for (int i = 0; i < N; i++)
            {
                string[] Vals = Console.ReadLine().Split(" ");
                
                double A = double.Parse(Vals[0]);
                double B = double.Parse(Vals[1]);
                double C = double.Parse(Vals[2]);

                double media = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}