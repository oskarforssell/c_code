using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        public List<Card> cards = new List<Card>();
       
        int[] rankNumbers = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13};
        int[] suitNumbers = new int[] {1,2,3,4};

        public Deck()
        {
            for (int i=0; i<4; i++) {
                for (int a=0; a<13; a++) {
                    Card kort = new Card(a,i);
                    cards.Add(kort);
                    //kort.Print();
                }
            }
            int deck_size = cards.Count;
        }
        public void Print() {
            int deck_size = cards.Count;
            Console.WriteLine(deck_size);

        }
        



        



        // list of suits (spade, diamond, heart, club)
        // list of ranks (1-13)
        // list of cards (13*spade, 13*diamond, 13*heart, 13*club = 52 cards)
        
        // represent the deck here
        // collection of 13 ranks each of 4 suits

        // print out the number of cards in the deck

        // PUBLIC METHODS
        // drawing any number of random cards from the deck (limited to number of cards lef in deck)
        // drawing any number of cards in order (limited to number of cards left in deck)
        // shuffle the deck


    }
}
