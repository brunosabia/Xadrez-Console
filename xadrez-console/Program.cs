using System;
using tabuleiro;
using tabuleiro.Exceptions;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();

            /*
            try
            { 
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));

                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            */
        }
    }
}
