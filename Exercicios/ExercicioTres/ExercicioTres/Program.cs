using System;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Dif;

            Console.WriteLine("Digite Valor 1");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Valor 2");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Valor 3");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Valor 4");
            D = int.Parse(Console.ReadLine());

            Dif = A * B - C * D;

            Console.WriteLine("Diferenca= " + Dif);

        }
    }
}
