using System;

namespace CardGame
{
    class Card
    {
        public string[] suitArray = new string[] { "spade", "diamond", "heart", "club" };
        public int[] rankArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        public int Rank { get; private set; }
        public string Suit { get; private set; }

        public Card(int rank, int suit)
        {
            Rank = rankArray[rank];
            Suit = suitArray[suit];
        }
        public void Print()
        {
            Console.WriteLine($"{Rank} of {Suit}s");
        }
        public string ReturnCard()
        {
            return $"{Rank} of {Suit}s";
        }

        // TO DECODE THE CARD RANK AND SUITE
        public int CardRank()
        {
            return Rank;
        }
        public int CardSuit()
        {
            switch (Suit)
            {
                case "spade":
                    return 1;
                case "diamond":
                    return 2;
                case "heart":
                    return 3;
                case "club":
                    return 4;
                default:
                    return 99;
            }
        }
    }
}
