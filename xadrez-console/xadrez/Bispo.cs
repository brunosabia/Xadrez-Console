using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override string ToString()
        {
            return "B ";
        }

        public override bool[,] movimentosPossiveis()
        {
            //criar uma matriz do mesmo tamanho que o tabuleiro
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //selecionar a posição NOROESTE da peça
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            //enquanto a posição estiver vazia e for valida, marcar a posição como livre(true)
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // caso a posição nao seja viavel, parar de tornar as posicoes true
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //caso a posição seja viavel, ela vai passar pelo if acima e vai subir para a linha de cima (linha - 1)
                pos.definirValores(pos.linha - 1, pos.coluna - 1);

            }




            //selecionar a posição NORDESTE da peça
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            //enquanto a posição estiver vazia e for valida, marcar a posição como livre(true)
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // caso a posição nao seja viavel, parar de tornar as posicoes true
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //caso a posição seja viavel, ela vai passar pelo if acima e vai subir para a linha de cima (linha - 1)
                pos.definirValores(pos.linha - 1, pos.coluna + 1);

            }

            //selecionar a posição SUDOESTE
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            //enquanto a posição estiver vazia e for valida, marcar a posição como livre(true)
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // caso a posição nao seja viavel, parar de tornar as posicoes true
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //caso a posição seja viavel, ela vai passar pelo if acima e vai subir para a linha de cima (linha - 1)
                pos.definirValores(pos.linha + 1, pos.coluna - 1);

            }

            //selecionar a posição SUDESTE
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            //enquanto a posição estiver vazia e for valida, marcar a posição como livre(true)
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // caso a posição nao seja viavel, parar de tornar as posicoes true
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                //caso a posição seja viavel, ela vai passar pelo if acima e vai subir para a linha de cima (linha - 1)
                pos.definirValores(pos.linha + 1, pos.coluna + 1);

            }

            return mat;
        }
    }

}
