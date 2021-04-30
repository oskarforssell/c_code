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
                    Console.WriteLine("0 means ZERO cards.. so no game! You loose!");
                    break;
                }
                else if (digit > 26)
                {
                    Console.WriteLine("Too manny cards! You can have 26 at most!");
                }
                else if (digit < 0)
                {
                    Console.WriteLine("Insanity! You can't play with a negative ammount of cards!! 0__0");
                }
                else if (digit < 27)
                {
                    Hand hand = new Hand();
                    Console.WriteLine($"The size of the hands: {ans}");
                    hand.Deal(digit);
                    Console.WriteLine("");

                    int playOn = 1;
                    while (playOn != 0)
                    {
                        playOn = hand.PlayCard();
                    }
                    break;
                }
            }
        }
        public GameEngine() { }
    }
}
