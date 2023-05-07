using System;
using System.Globalization;//cultura goblas

namespace ExercicoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, pi = 3.14159;

            Console.WriteLine("Digite o valor do Raio");

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// fixa valor . em vez de ,

            A = pi * R *R;

            Console.WriteLine("A =" + A.ToString("F4", CultureInfo.InvariantCulture));// fixa valor . em vez de , "F4" numero de casas decimais?

        }
    }
}
