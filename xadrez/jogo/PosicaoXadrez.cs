﻿using System;
using tabuleiro;

namespace jogo{

    class PosicaoXadrez{

        public char coluna { get; set; }
        public int  linha  { get; set; }

        public PosicaoXadrez(char coluna, int linha) {

            this.linha = linha;
            this.coluna = coluna;
        }


        public Posicao toPosicao() {

            return new Posicao( 8 - this.linha , this.coluna - 'a' );

        }



        public override string ToString() {
            return ""  + this.linha + this.coluna;
        }

    }
}