using System;

namespace ExercucioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha de 4 digitos para acessar: ");
            int password = int.Parse(Console.ReadLine());
            

            while (password != 2002)
            {
                Console.WriteLine("Senha invalida!, digite nova senha");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senhan aceira! acesso concedido!");

        }
    }
}