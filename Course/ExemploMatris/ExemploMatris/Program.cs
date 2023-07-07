using System;

namespace ExemploMatris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do tamanho da matris: ");

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int ContLinha = i + 1;
                Console.WriteLine("Digite os " + n + " valores a serem inseridos na linha " + ContLinha);
                string[] valores = Console.ReadLine().Split(" ");


                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("Quantidade de numeros negativos");
            int ContNegativo = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        ContNegativo++;
                    }
                }
            }
            Console.WriteLine("Contagem de numeros negativos da mateis é de: " + ContNegativo);
        }
    }
}
