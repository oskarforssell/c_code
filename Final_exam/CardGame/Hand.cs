using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Hand
    {
        public Deck pack = new Deck();
        public List<Card> playerHand = new List<Card>();
        public List<Card> AIHand = new List<Card>();

        public int playerScore = 0;
        public int aiScore = 0;

        public int PlayerHandSize()
        {
            return playerHand.Count;
        }

        public void PrintPlayerHand()
        {
            Console.WriteLine("Your cards: ");
            for (int i = 0; i < playerHand.Count; i++)
            {
                Card one = playerHand[i];
                Console.Write($"{i.ToString()}: ");
                one.Print();
            }
        }
    }
}
