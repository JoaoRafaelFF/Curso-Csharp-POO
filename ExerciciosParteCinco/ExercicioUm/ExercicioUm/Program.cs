using System;
using System.Globalization;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCliente conta;

            Console.Write("Entre o numero da conta:  ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Havera deposito inicial (S/N)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaCliente(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaCliente(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}