using System;

namespace ExercicioMartiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para definir o tamanha da matris: ");

            string[] tamanhoMN = Console.ReadLine().Split(" ");

            int m = int.Parse(tamanhoMN[0]);

            int n = int.Parse(tamanhoMN[1]);


            int[,] mat = new int[m, n];

            // carrega a matriz 
            for (int i = 0; i < m; i++)
            {
                int contline = i + 1;
                Console.WriteLine("Digite os valores da linha " + contline + " a serem inseridos: ");
                string[] valores = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }

            }

            //imprime a matriz
            Console.WriteLine("sua matriz é: ");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
            }



            Console.WriteLine();
            Console.WriteLine("Digite um numero inteiro para saber há valores proximos a ele na matriz: ");
            
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        int ContPosX = i + 1;
                        int ContPosY = j + 1;
                        Console.WriteLine("posicão " + ContPosX + " , " + ContPosY + ": ");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
