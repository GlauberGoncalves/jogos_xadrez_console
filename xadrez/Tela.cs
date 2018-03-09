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
                    if( tab.peca(i , j) == null)
                    {
                        Console.Write("- ");
                    } else {
                        Tela.imprimePeca( tab.peca( i , j ) );
                        Console.Write( " " );
                    }                    
                }                
                Console.WriteLine();
            }
            Console.Write( "  a b c d e f g h" );            
        }

        public static PosicaoXadrez lerPosicaoXadrez() {

            Console.WriteLine( "\nOrigem: " );
            String x = Console.ReadLine();
            
            int linha = int.Parse( x[0] + "" );
            char coluna = x[1];

            return new PosicaoXadrez( coluna , linha );                        
        }

        public static void imprimePeca( Peca peca) {
            if (peca.cor == Cor.Branca)
                Console.Write( peca );
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write( peca );
                Console.ForegroundColor = aux;
            }
        }
    }
}
