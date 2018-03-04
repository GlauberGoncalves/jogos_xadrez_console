using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args){
            Posicao P;


            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.colocarPeca( new Torre(tabuleiro, Cor.Preta), new Posicao(7, 0));
            tabuleiro.colocarPeca( new Rei( tabuleiro , Cor.Branca ) , new Posicao( 7 , 3 ) );
            tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 7 , 7 ) );

            
            // teste posição dublicada
            // tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 5 , 6 ) );

            // teste posição invalida
            // tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 9 , 9 ) );
            // Tela.imprimeTabuleiro(tabuleiro);

            // PosicaoXadrez posicao = new PosicaoXadrez( 'h' , 3 );

            
            Tela.imprimeTabuleiro( tabuleiro );
            


            Console.ReadLine();
        }
    }
}