using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args){
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while( partida.terminada != true ) {

                Console.Clear();
                Tela.imprimeTabuleiro( partida.tab );


                Posicao origem  = Tela.lerPosicaoXadrez().toPosicao();
                Console.Clear();

                bool[,] posicoesPossiveis = partida.tab.peca( origem ).movimentosPossiveis();

                Tela.imprimeTabuleiro( partida.tab , posicoesPossiveis );

                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                if( posicoesPossiveis[ destino.linha, destino.coluna ]) {
                    partida.executaMovimento( origem , destino );
                } else {
                    Console.Write( "Jogada Invalida!!!" );
                }

                

            }
            
            // teste posição dublicada
            // tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 5 , 6 ) );

            // teste posição invalida
            // tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 9 , 9 ) );
            // Tela.imprimeTabuleiro(tabuleiro);

            // PosicaoXadrez posicao = new PosicaoXadrez( 'h' , 3 );


            // Tela.imprimeTabuleiro( tabuleiro );
            


            Console.ReadLine();
        }
    }
}