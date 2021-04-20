using System;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pawn piece = new Pawn("A2","White");
            Console.WriteLine(piece.Location);
            piece.Move()
        }
    }
}
