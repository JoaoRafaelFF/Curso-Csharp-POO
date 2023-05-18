using System;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ajude na nossa pesquisa, digite o tipo de combustivel que abasteceu e a opcao 4 para finalizar a pesquisa ");
            Console.WriteLine("Alcool - 1");
            Console.WriteLine("Gasolina - 2");
            Console.WriteLine("Diesel - 3");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int Tipo = int.Parse(Console.ReadLine());

            while (Tipo != 4)
            {
                if (Tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (Tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (Tipo == 3)
                {
                    diesel = diesel + 1;
                }

                Tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado por ajudar na pesquisa!");
            Console.WriteLine("Resultados: ");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
