using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro{
        public int linhas  { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro( int linhas, int colunas){
            this.linhas     = linhas;
            this.colunas    = colunas;
            this.pecas      = new Peca[this.linhas, this.colunas];
        }

        public Peca peca(int linha, int coluna){
            return this.pecas[linha,coluna];
        }

        public void colocarPeca( Peca peca, Posicao posicao ){
            peca.posicao = posicao;
            this.pecas[posicao.linha, posicao.coluna] = peca;            
        }


    }
}
