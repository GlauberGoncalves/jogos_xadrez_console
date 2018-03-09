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

        public Peca peca(Posicao posicao) {
            return this.pecas[posicao.linha , posicao.coluna];
        }

        public void colocarPeca( Peca peca, Posicao posicao ){

            if (this.exitePeca( posicao )) {
                throw new TabuleiroException( "Já existe peça nesta posição" );
            }

            peca.posicao = posicao;
            this.pecas[posicao.linha, posicao.coluna] = peca;            
        }

        public Peca retirarPeca(Posicao posicao) {

            if (this.peca( posicao ) == null)
                return null;

            Peca aux = this.peca( posicao );
            aux.posicao = null;

            this.pecas[posicao.linha , posicao.coluna] = null;
            return aux;
                        
        }

        public bool exitePeca(Posicao posicao) {

            validarPosicao( posicao );
            return  this.peca( posicao ) != null ;                            
        }


        public bool posicaoValida( Posicao posicao) {

            if ( posicao.linha < 0 || posicao.coluna < 0 || posicao.linha >= this.linhas || posicao.coluna >= this.colunas ){
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao posicao) {
            if( !posicaoValida(posicao)) {
                throw new TabuleiroException( "Posição invalida" );
            }
        }



    }
}
