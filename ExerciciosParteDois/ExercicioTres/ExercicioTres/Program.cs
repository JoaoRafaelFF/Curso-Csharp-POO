using System;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros para saber se são multiplos");

            string[] Val = Console.ReadLine().Split(" ");
            int Val1 = int.Parse(Val[0]);
            int Val2 = int.Parse(Val[1]);

            if (Val1 % Val2 == 0 || Val2 % Val1 == 0)
            {
                Console.WriteLine("São numeros Multiplos!");
            }
            else
            {
                Console.WriteLine("Não são numeros Multiplos!");
            }
        }
    }
}
