using tabuleiro;
using xadrez;
namespace ProjetoSistemaJogoXadres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testes 
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPecas(new Rei(tab,Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}