using tabuleiro;
namespace ProjetoSistemaJogoXadres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testes 
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}