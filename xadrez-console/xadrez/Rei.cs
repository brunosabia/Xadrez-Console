using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        //método para verificar se pode mover a peca
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
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
            return mat;
        }

        public override string ToString()
        {
            return "R ";
        }
    }

}
