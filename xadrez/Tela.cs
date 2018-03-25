using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    class Tela{
        
        public static void imprimeTabuleiro(Tabuleiro tab){
            for( int i = 0; i < tab.linhas; i++)
            {
                Console.Write( 8 - i + " ");
                for(int j = 0; j < tab.colunas; j++){
                    Tela.imprimePeca( tab.peca( i , j ) );                                                
                }                
                Console.WriteLine();
            }
            Console.Write( "  a b c d e f g h" );            
        }

        public static void imprimeTabuleiro(Tabuleiro tab , bool[,] posicoesPossiveis) {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++) {
                Console.Write( 8 - i + " " );
                for (int j = 0; j < tab.colunas; j++) {

                    if (posicoesPossiveis[i , j]) {
                        Console.BackgroundColor = fundoAlterado;

                    } else {
                        Console.BackgroundColor = fundoOriginal;
                    }


                    Tela.imprimePeca( tab.peca( i , j ) );
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.Write( "  a b c d e f g h" );
            Console.BackgroundColor = fundoOriginal;

        }

        public static PosicaoXadrez lerPosicaoXadrez() {

            Console.WriteLine( "\nOrigem: " );
            String x = Console.ReadLine();

            char coluna = x[0];
            int linha = int.Parse( x[1] + "" );
            

            return new PosicaoXadrez( coluna , linha );                        
        }

        public static void imprimePeca( Peca peca) {

            if (peca == null) {
                Console.Write( "- " );
            } else {
            
                if (peca.cor == Cor.Branca)
                    Console.Write( peca );
                else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write( peca );
                    Console.ForegroundColor = aux;
                }
                Console.Write( " " );
            }
        }
    }
}
