using System;
using System.Globalization;

namespace ExemploVetorUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de entradas a serem feitas no programa: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o valor a ser entrado");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0;i < n; i++) 
            { 
                soma += vect[i];
            }

            double avg = soma / n;

            Console.WriteLine("A media das alturas é: " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}