using System;
using tabuleiro;


namespace jogo
{
    class PartidaDeXadrez {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadaAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez() {
            this.tab = new Tabuleiro( 8 , 8 );
            this.turno = 1;
            this.jogadaAtual = Cor.Branca;
            this.terminada = false;
            this.colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = this.tab.retirarPeca( origem );
            p.incrementarQteMovimentos();
            Peca pecaCapturada = this.tab.retirarPeca( destino );
            this.tab.colocarPeca( p , destino );            
        }

        private void colocarPecas() {
                        
            this.tab.colocarPeca( new Torre( this.tab , Cor.Preta ) , new PosicaoXadrez( 'c' , 1 ).toPosicao() );
            this.tab.colocarPeca( new Torre( this.tab , Cor.Preta ) , new PosicaoXadrez( 'c' , 2 ).toPosicao() );
            this.tab.colocarPeca( new Torre( this.tab , Cor.Preta ) , new PosicaoXadrez( 'd' , 2 ).toPosicao() );
            this.tab.colocarPeca( new Torre( this.tab , Cor.Preta ) , new PosicaoXadrez( 'e' , 2 ).toPosicao() );
            this.tab.colocarPeca( new Torre( this.tab , Cor.Branca ), new PosicaoXadrez( 'e' , 1 ).toPosicao() );
            this.tab.colocarPeca( new Rei( this.tab , Cor.Preta )   , new PosicaoXadrez( 'd' , 1 ).toPosicao() );


        }
    }
}
