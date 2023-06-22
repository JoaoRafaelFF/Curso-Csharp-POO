using System;
using System.Globalization;

namespace ExemploVetorDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita a quantidade de entradas a serem feitas no programa: ");

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string name = Console.ReadLine();

                Console.WriteLine("Digite o preco do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[n] = new Product { NomeProduto = name, PrecoProduto = preco };
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].PrecoProduto;
            }

            double avg = soma / n;

            Console.WriteLine("Media de preco dos produtos: " + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}


