using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    class Peca
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
    }
}
