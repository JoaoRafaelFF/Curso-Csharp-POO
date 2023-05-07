using System;

namespace ExercicioUm;

class Program
{
    static void Main(string[] args)
    {
        int A, B, Soma;
        Console.WriteLine("digite valor 1");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("digite valor 2");
        B = int.Parse(Console.ReadLine());

        Soma = A + B;

        Console.WriteLine("Soma = " + Soma);
    }
}

