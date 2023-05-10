using System;

namespace EstruturaCondicionalIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simples
            //int x = 10;
            //Console.WriteLine("Bom dia!");
            //if (x > 5)
            //{
            //Console.WriteLine("Boa Tarde!");
            //}
            //Console.WriteLine("Boa Noite!");


            //compsta
            //.WriteLine("Entre com um numero inteiro! ");
            //int x = int.Parse(Console.ReadLine());
            //if (x % 2 == 0)
            // {
            //Console.WriteLine("numero par!");
            //}
            //else
            //{
            //Console.WriteLine("numero impar!");


            Console.WriteLine("Digite a hora atual!");

            int Hora = int.Parse(Console.ReadLine());

            if (Hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (Hora < 18)
            {
                Console.WriteLine("Boa Taede!");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }


    }
}
