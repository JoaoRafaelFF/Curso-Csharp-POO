using System;
using System.Globalization;

namespace ExerPropEntradaDeDadosUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o numero de quartos da sua casa: ");
            int Quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto: ");
            double Precproduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura: (mesma linha) ");
            string[] Vet = Console.ReadLine().Split(" ");
            String LastName = Vet[0];
            int Idade = int.Parse(Vet[1]);
            double Altura = double.Parse(Vet[2]);



            Console.WriteLine("Voce Digitou: ");
            Console.WriteLine(Nome);
            Console.WriteLine(Quartos);
            Console.WriteLine(Precproduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(LastName);
            Console.WriteLine(Idade);
            Console.WriteLine(Altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}