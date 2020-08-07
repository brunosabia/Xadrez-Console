using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
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

            pos.definirValores(posicao.linha - 1, posicao.coluna - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha - 2, posicao.coluna -1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha - 1, posicao.coluna + 2);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha + 1, posicao.coluna + 2);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 2, posicao.coluna + 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha + 2 , posicao.coluna - 1);
            //SE a posição for valida(dentro do tabuleiro e maior que 0) 
            //Se a posicao destino estiver vazia ou for da cor do time oposto, a posição é valida.
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //selecionar a posição NOROESTE da peça
            pos.definirValores(posicao.linha + 1, posicao.coluna - 2);
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
            return "C ";
        }
    }

}
