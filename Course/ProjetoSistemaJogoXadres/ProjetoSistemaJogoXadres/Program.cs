using tabuleiro;
using xadrez;
namespace ProjetoSistemaJogoXadres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testes 
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.colocarPecas(new Rei(tab, Cor.Preta), new Posicao(0, 0)); /*dispara validacao já existe peca se ativo */
                //tab.colocarPecas(new Rei(tab, Cor.Preta), new Posicao(0, 9)); /*dispara validacao posicao invalida se ativo */
                tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPecas(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }

            catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}