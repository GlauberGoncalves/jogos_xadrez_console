﻿using tabuleiro;

namespace jogo
{
    class Rei: Peca {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base (tabuleiro, cor){

        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca( pos );
            return p == null || p.cor != this.cor;
        }


        public override bool[,] movimentosPossiveis() {

            bool[,] mat = new bool[tab.linhas , tab.colunas];
            Posicao pos = new Posicao( 0 , 0 );

            // acima
            pos.definirValores( posicao.linha - 1 , posicao.coluna );
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // cima diagonal direita
            pos.definirValores( posicao.linha - 1 , posicao.coluna + 1 );
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // direita
            pos.definirValores( posicao.linha , posicao.coluna + 1 );
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // baixo diagonal direita
            pos.definirValores( posicao.linha + 1 , posicao.coluna + 1);
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // baixo
            pos.definirValores( posicao.linha + 1 , posicao.coluna );
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // baixo diagonal esquerda
            pos.definirValores( posicao.linha + 1 , posicao.coluna - 1);
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // esquerda
            pos.definirValores( posicao.linha  , posicao.coluna - 1 );
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            // acima diagonal esquerda
            pos.definirValores( posicao.linha - 1 , posicao.coluna - 1 );
            if (tab.posicaoValida( pos ) || podeMover( pos )) {
                mat[pos.linha , pos.coluna] = true;
            }

            return mat;

        }

    }
}
