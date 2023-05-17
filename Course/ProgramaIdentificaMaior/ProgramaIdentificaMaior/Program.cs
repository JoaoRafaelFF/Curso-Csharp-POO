using System;
using System.Data;

namespace ProgramaIdentificaMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Maior " + n1);
            //}
            //else if (n2 > n3)
            //{
            //    Console.WriteLine("Maior " + n2);
            //}
            //else
            //{
            //    Console.WriteLine("Maior "+ n3);
            //}
            // tudo isso é a funcao maior

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
