using System;

namespace ExercicioQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a gora de inicio e termino de uma partida de jogo");

            string[] Partida = Console.ReadLine().Split(" ");
            int Inicio = int.Parse(Partida[0]);
            int Fim = int.Parse(Partida[1]);
            int Duracao;

            if (Inicio < Fim)
            {
                Duracao = Fim - Inicio;
            }
            else
            {
                Duracao = 24 - Inicio + Fim;
            }

            Console.WriteLine("O jogo durou " + Duracao + " horas");

        }
    }
}