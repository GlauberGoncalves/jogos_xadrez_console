using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args){
            Posicao P;

            PartidaDeXadrez partida = new PartidaDeXadrez();

            while( partida.statusPartida != true ) {

                Console.Clear();
                Tela.imprimeTabuleiro( partida.tab );


                Posicao origem  = Tela.lerPosicaoXadrez().toPosicao();
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento( origem , destino );

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