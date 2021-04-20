using System;

namespace ChessGame
{
    class Pawn : IChessPiece
    {
        public string Location { get; set; }
        public string Color { get; set; }

        public Pawn(string location, string color)
        {
            Location = location;
            Color = color;
        }
        public void Move()
        {
            Console.WriteLine("Pawn moved to who-knows-where");
        }
    }
}
