using System;
using System.Collections.Generic;

namespace CardGame
{
    public class GameEngine
    {

        public void Start()
        {
            while (true)
            {
                Console.Write("How many cards do you want (1-26)? ");
                string ans = Console.ReadLine();
                int digit = Int16.Parse(ans);
                if (digit == 0)
                {
                    Console.WriteLine("Well you quit early!");
                    break;
                }
                else if (digit > 26)
                {
                    Console.WriteLine("Too manny cards! You can have 26 at most!");
                }
                else if (digit < 1)
                {
                    Console.WriteLine("Insanity! You can't play without cards!! 0__0");
                }
                else if (digit < 27)
                {
                    GameEngine newGame = new GameEngine(digit);
                    break;
                }
            }
        }
        public GameEngine() { }

        public GameEngine(int cardsPerPlayer)
        {
            Hand hand = new Hand();
            hand.GetPlayerHand(cardsPerPlayer);

            int playOn = 1;
            while (playOn != 0)
            {
                playOn = hand.PlayCard();
            }

        }

        // based on how many cards the player wants, take that many random cards and give it to player and AI. (so between 1-26 cards)
    }
}
