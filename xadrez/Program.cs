using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args){
            Posicao P;

            try { 
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.colocarPeca( new Torre(tabuleiro, Cor.Preta), new Posicao(7, 0));                
                tabuleiro.colocarPeca( new Rei(tabuleiro, Cor.Preta), new Posicao(7, 3));                
                // teste posição dublicada
                // tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 5 , 6 ) );
                
                // teste posição invalida
                // tabuleiro.colocarPeca( new Torre( tabuleiro , Cor.Preta ) , new Posicao( 9 , 9 ) );

                Tela.imprimeTabuleiro(tabuleiro);

            } catch( TabuleiroException e) {

                Console.WriteLine( e.Message );

            }
            Console.ReadLine();
        }
    }
}