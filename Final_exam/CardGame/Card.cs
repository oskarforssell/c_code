using System;

namespace CardGame
{
    class Card
    {
        public string[] suitArray = new string[] {"spade", "diamond", "heart", "club"};
        public int[] rankArray = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13};

        public int Rank { get; private set; }
        public string Suit { get; private set; }
        
        public Card(int rank, int suit)
        {
            Rank = rankArray[rank];
            Suit = suitArray[suit];
        }
        public void Print() {
            Console.WriteLine($"{Rank} of {Suit}s");
        }
    }
}
