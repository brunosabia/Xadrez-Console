using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        //Método para imprimir tabuleiro e pecas
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");


                for (int j = 0; j < tab.colunas; j++)
                {
                    

                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        //Método para controlar as cores das pecas
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                //Linha abaixo salva a cor atual pra "aux"
                ConsoleColor aux = Console.ForegroundColor;
                //Muda a cor padrão para yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                //imprime a peca na cor padrão atual (yellow)
                Console.Write(peca);
                //volta a cor padrão original
                Console.ForegroundColor = aux;
            }
        }

        //Ler a posicao que o usuário digita
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha =int.Parse( s[1]+ "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
