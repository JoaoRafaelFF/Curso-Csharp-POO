using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qunatos Funcionarios serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario " + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionarios(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Entre com o Id do funcionario que recebera aumento de salario : ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionarios func = list.Find(x => x.Id == procuraId);
            if (func != null)
            {
                Console.Write("Digite a porcentagem a ser aumentada no salario:");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id nao existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios atualizada: ");
            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
