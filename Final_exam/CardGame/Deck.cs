using System;
using System.Collections.Generic;

namespace CardGame
{
    class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 13; a++)
                {
                    Card kort = new Card(a, i);
                    cards.Add(kort);
                }
            }
            int deck_size = cards.Count;
        }

        public void PrintDeckSize()
        {
            int deck_size = cards.Count;
            Console.WriteLine($"{deck_size} cards left in the deck.");
        }

        public void ShuffleTheDeck()
        {
            for (int n = 0; n < 25; n++)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    Random rand = new Random();
                    int randomTake = rand.Next(0, (cards.Count - 1));
                    cards.Add(cards[randomTake]);
                    cards.RemoveAt(randomTake);
                }
            }
        }
    }
}
