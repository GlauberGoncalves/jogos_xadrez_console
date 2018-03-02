using System;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args){
            Posicao P;

            Tabuleiro tab = new Tabuleiro(20, 20);
            Tela.imprimeTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
