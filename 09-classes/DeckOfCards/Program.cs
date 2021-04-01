using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pino = new Deck();
            Card kortti = new Card(1,1);
            kortti.Print();
            //pino.cards.Add(kortti);
            
            // Card kortti = new Card(2,"spade");
            // pino.cards.Add(kortti);
            pino.Print();
            
            
            
            
        }
    }
}
