using System;
using System.Collections.Generic;

namespace CardGame
{
    public class GameEngine
    {
        
        // List<Deck> playerHand = new List<Deck>();

        public GameEngine(int cardsPerPlayer)
        {
            Deck gameDeck = new Deck();
            gameDeck.PrintDeckSize();  // remove this
            Console.Write("Player chose: ");
            Console.WriteLine(cardsPerPlayer);
            Console.WriteLine("----");

            gameDeck.ShuffleTheDeck();

            gameDeck.DrawFromTopOfDeck(cardsPerPlayer);
            // playerHand.Add(gameDeck.DrawFromTopOfDeck(cardsPerPlayer));

            gameDeck.PrintDeckSize();  // remove this
            Console.WriteLine("---cards removed and stored in list? ---");

            // Console.WriteLine(playerHand);
            gameDeck.DealCards(cardsPerPlayer);
            gameDeck.PrintAIHandSize();
            gameDeck.PrintPlayerHandSize();

            gameDeck.PrintDeckSize();

        }

        // Create a new deck in here
        // shuffle the deck
        // based on how many cards the player wants, take that many random cards and give it to player and AI. (so between 1-26 cards)


    }
}
