using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }

        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }


        //construtor base
        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        //Incrementa a variavel "qteMovimentos"
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        //esse metodo vai pegar a matriz bool dos movimentos possiveis e verificar se existe pelo menos UM movimento possível para ser realizado.
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();

            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }

                }

            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];

        }


        //método abstrato que sera implementado em cada uma das subclasses com as devidas posicoes que a peca poderá ocupar
        public abstract bool[,] movimentosPossiveis();
        
    }
}
