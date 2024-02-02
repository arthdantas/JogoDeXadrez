using System.Runtime.CompilerServices;
using System.Xml;
using xadrez_console;
using tabuleiro;
using xadrez;

        

class Program
{
     static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('c',7);
        Console.WriteLine(pos);
        Console.WriteLine(pos.toPosicao());

        Console.ReadLine();
        
        
    }
}