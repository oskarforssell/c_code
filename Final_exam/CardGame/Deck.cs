using System;
using System.Collections.Generic;

namespace CardGame
{
    class Deck
    {
        public List<Card> cards = new List<Card>();
        public List<Card> playerHand = new List<Card>();   // ADDED FOR CARD GAME
        public List<Card> AIHand = new List<Card>();   // ADDED FOR CARD GAME

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
        public void PrintDeckCards()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Card print_card = cards[i];
                print_card.Print();
            }
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


        //////////////////   NEW GAME CODE BELOW THIS
        public void DealCards(int cardsToBeDrawn)
        {
            if (cardsToBeDrawn <= cards.Count)
            {
                for (int i = 0; i < cardsToBeDrawn; i++)
                {
                    Card player_card = cards[0];
                    Card AI_card = cards[1];
                    playerHand.Add(player_card);
                    AIHand.Add(AI_card);
                    cards.RemoveAt(0);
                    cards.RemoveAt(0);
                }
            }
            else { Console.WriteLine($"Can't take {cardsToBeDrawn} cards, only {cards.Count} cards left.."); }
        }
        public void PrintPlayerHandSize()
        {
            int deck_size = playerHand.Count;
            Console.WriteLine($"The player has {deck_size} cards");
        }
        public int PlayerHandSize()
        {
            return playerHand.Count;
        }
        public int AIHandSize()
        {
            return AIHand.Count;
        }
        public void PrintAIHandSize()
        {
            int deck_size = AIHand.Count;
            Console.WriteLine($"The AI has {deck_size} cards");
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
        public void PrintAIHand()                       /// FOR DEBUGGING!
        {
            Console.WriteLine("AI cards: ");            //
            for (int i = 0; i < AIHand.Count; i++)      //
            {
                Card one = AIHand[i];                   //
                Console.Write($"{i.ToString()}: ");     //
                one.Print();                            //
            }

        }

        public void RemoveFromPlayerHand(int index)
        {
            playerHand.RemoveAt(index);
        }
        public void RemoveFromAIHand(int index)
        {
            AIHand.RemoveAt(index);
        }
    }
}
