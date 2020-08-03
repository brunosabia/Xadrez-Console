using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro.Exceptions;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;


        //Construtor
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        
        
        //setar a posição da peca no tabuleiro
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    
        //sobrecarga do metodo acima recebendo apenas a posição da pessa por parametro
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        //Método para testar se existe uma peça na posição passada por param
        public bool existePeca(Posicao pos)
        {
            //testar se a posicao é valida
            validarPosicao(pos);
            //retornar true somente se a posicao for diferente(!=) de null;
            return peca(pos) != null;
        }




        //metodo para colocar a peça na matriz "pecas" e setar a Posição da peca
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        //Método para retirar uma peça de uma posição
        public Peca retirarPeca(Posicao pos)
        {
            //se a posicao for vazia, retornar null e seguir.
            if(peca(pos) == null)
            {
                return null;
            }
            else
            {
                //joga a peca para uma posição auxiliar, limpa a posição dela na matriz e retorna a peca que foi retirada para decidir para onde ela será encaminhada
                Peca aux = peca(pos);
                aux.posicao = null;
                pecas[pos.linha, pos.coluna] = null;
                return aux;
            }
        }


        //método usado para verificar se a posição do tabuleiro é valida
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //método para jogar a exception caso a posicao seja invalida
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    
    }
}
