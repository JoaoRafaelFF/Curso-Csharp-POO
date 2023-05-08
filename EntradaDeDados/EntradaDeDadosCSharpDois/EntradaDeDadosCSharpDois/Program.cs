using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Idade:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Sexo:");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Altura:");
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a Altura:");
            string[] vet = Console.ReadLine().Split(" ");
            string Nome = vet[0];
            char Sexo = char.Parse(vet[1]);
            int Idade = int.Parse(vet[2]);
            double Altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Voce Digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(Nome);
            Console.WriteLine(Sexo);
            Console.WriteLine(Idade);
            Console.WriteLine(Altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}