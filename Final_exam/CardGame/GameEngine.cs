using System;
using System.Collections.Generic;

namespace CardGame
{
    public class GameEngine
    {
        // Deck pack = new Deck();
        Hand hand = new Hand();
        public void Start()
        {
            while (true)
            {
                Console.Write("How many cards do you want (1-26)? ");
                string ans = Console.ReadLine();
                int digit = Int16.Parse(ans);
                if (digit > 26) { Console.WriteLine("Too manny cards! You can have 26 at most!"); }
                else if (digit < 1) { Console.WriteLine("Insanity! You need cards to play!! 0__0"); }
                else if (digit < 27)
                {
                    Console.WriteLine($"The size of the hands: {ans}");
                    Deal(digit);
                    Console.WriteLine("");

                    int[] playWin = new int[2] { 1, 0 };
                    // playWin[0] = 1 -> continue game / 0 -> end game
                    // playWin[1] = 0 -> player plays first / 1 -> ai plays first
                    while (playWin[0] != 0)
                    {
                        playWin = hand.PlayCard(playWin[1]);
                    }
                    break;
                }
            }
        }
        public GameEngine() { }

        public void Deal(int cardNum)
        {
            hand.pack.ShuffleTheDeck();
            DealCards(cardNum);
        }
        public void DealCards(int cardsToBeDrawn)
        {
            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                Card player_card = hand.pack.cards[0];
                Card AI_card = hand.pack.cards[1];
                hand.playerHand.Add(player_card);
                hand.AIHand.Add(AI_card);
                hand.pack.cards.RemoveAt(0);
                hand.pack.cards.RemoveAt(0);
            }
            hand.pack.PrintDeckSize();
        }
    }
}
