using System;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa: ");
            Console.WriteLine("Nome :");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: "+ p2.Nome);
            }
        }
    }
}