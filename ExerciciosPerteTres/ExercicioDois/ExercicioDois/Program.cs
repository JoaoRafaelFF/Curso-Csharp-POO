using System;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite dois pontos para identificar o ponto cartesiano!");

            string[] Vals = Console.ReadLine().Split(" ");
            int X = int.Parse(Vals[0]);
            int Y = int.Parse(Vals[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro Quadrante");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Seguindo Quadrante");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("quarto Quadrante");
                }
                Vals = Console.ReadLine().Split(' ');
                X = int.Parse(Vals[0]);
                Y = int.Parse(Vals[1]);

            }
        }
    }
}