using System;

namespace ExercicioSete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois Valores para saber em qual quadrante o ponto esta!");

            string[] Ponto = Console.ReadLine().Split(" ");
            double X = double.Parse(Ponto[0]);
            double Y = double.Parse(Ponto[1]);

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Quadrante Q1");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Quadrante Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Quadrante Q3");
            }
            else
            {
                Console.WriteLine("Quadrante Q4");
            }

        }
    }
}