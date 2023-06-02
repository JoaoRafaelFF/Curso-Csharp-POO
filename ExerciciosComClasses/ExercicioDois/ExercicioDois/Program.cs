using System;
using System.Globalization;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionario: ");
            Console.WriteLine("Nome");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do primeiro funcionario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo funcionario: ");
            Console.WriteLine("Nome");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("A media dos salarios de " + f1.Nome + " e " + f2.Nome + " é de: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}