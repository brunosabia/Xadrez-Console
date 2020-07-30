using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        //Método para imprimir tabuleiro e pecas
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }

                    Console.Write( tab.peca(i,j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
