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

            tabuleiro.colocarPeca( new Torre(tabuleiro, Cor.Preta), new Posicao(3, 3));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(5, 6));



            Tela.imprimeTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}