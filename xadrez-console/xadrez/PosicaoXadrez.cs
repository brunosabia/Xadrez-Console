using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        //Construtor
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        //metodo para converter as posicoes da matriz em posições do padrão de xadrez
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
            //Subtraindo de A = a - a = 0 , a - b = 1, a - c = 2... Logo, é possivel calcular desta forma.
        }


        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
