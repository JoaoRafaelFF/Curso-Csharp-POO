using System;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita a quantidade de numeros inteiros a derem inseridos");

            int n = int.Parse(Console.ReadLine());

            int ContIn = 0;
            int ContOut = 0;

            Console.WriteLine("digite os Valores a serem inseridos");
            for (int i = 0; i < n; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    ContIn = ContIn + 1;
                }
                else
                {
                    ContOut = ContOut + 1;
                }
            }
            Console.WriteLine("Resultados");
            Console.WriteLine(ContIn + " In");
            Console.WriteLine(ContOut + " Out");
        }
    }
}