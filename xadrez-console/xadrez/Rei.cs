using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;

       

        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        //método para verificar se pode mover a peca
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        //método de teste de posicao para jogada especial Roque pequeno e Roque grande
        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qteMovimentos == 0;
        }




        public override bool[,] movimentosPossiveis()
        {
            //criar uma matriz do mesmo tamanho que o tabuleiro
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //selecionar a posição ACIMA da peça
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //selecionar a posição NORDESTE
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //selecionar a posição A DIREITA da peça
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //selecionar a posição SUDESTE
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //selecionar a posição ABAIXO da peça
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //selecionar a posição SUDOESTE
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //selecionar a posição A ESQUERDA da peça
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //selecionar a posição NOROESTE da peça
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }




            //JOGADA ESPECIAL == Roque PEQUENO
            if (qteMovimentos == 0 && !partida.xeque)
            {
                //roque pequeno
                Posicao posT1 = new Posicao(posicao.linha, posicao.coluna + 3);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if (tab.peca(p1) == null && tab.peca(p2) == null)
                    {
                        mat[posicao.linha, posicao.coluna + 2] = true;
                    }

                }


                //JOGADA ESPECIAL == roque grande
                Posicao posT2 = new Posicao(posicao.linha, posicao.coluna - 4);
                if (testeTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao p3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                    {
                        mat[posicao.linha, posicao.coluna - 2] = true;
                    }

                }
            }




            return mat;
        }

        public override string ToString()
        {
            return "R ";
        }
    }

}
