using System;
using System.Globalization;

namespace ExercicioQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de entradas a serem inseridas  ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite dois numeros um dera o para serem divididos! ");

                string[] Vals = Console.ReadLine().Split(" ");
                int X = int.Parse(Vals[0]);
                int Y = int.Parse(Vals[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }

                else
                {
                    double div = (double)X / Y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));

                }
            }
        }
    }
}
