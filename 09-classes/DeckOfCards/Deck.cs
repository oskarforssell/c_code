using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        public List<Card> cards = new List<Card>();

        // public string[] suitArray = new string[] {"spade", "diamond", "heart", "club"};
        // public int[] rankArray = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13};
        


        public void Print() {
            Card something = new Card(3,3);
            something.Print();

            // Console.WriteLine(something.Print());
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
