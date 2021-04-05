using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pino = new Deck();
            //Card kortti = new Card(1,1);
            //kortti.Print();
            //pino.cards.Add(kortti);
            
            // Card kortti = new Card(2,"spade");
            // pino.cards.Add(kortti);
            pino.PrintDeckSize();
            
            // pino.DrawRandomCards(47);
            // pino.Print();
            // pino.DrawRandomCards(8);
            // pino.Print();
            //pino.DrawFromTopOfDeck(5);
            //pino.Print();
            pino.PrintDeckCards();
            pino.ShuffleTheDeck();
            pino.PrintDeckSize();
            
            pino.PrintDeckCards();


            
            
        }
    }
}
