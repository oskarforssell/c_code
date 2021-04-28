using System;
using System.Collections.Generic;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("How many cards do you want (1-26)? ");
                string ans = Console.ReadLine();
                int digit = Int16.Parse(ans);
                if (digit == 0) { break; }
                else if (digit > 26)
                {
                    Console.WriteLine("Too manny cards! You can have 26 at most!");
                }
                else if (digit < 27)
                {
                    GameEngine newGame = new GameEngine(digit);
                    break;
                }
            }

            // Console.WriteLine(ans);

            // create

            // newGame.ToString();


            // Deck pino = new Deck();
            // pino.PrintDeckSize();
            // Console.WriteLine("------------");
            // pino.PrintDeckCards();
            // Console.WriteLine("------------");

            // pino.ShuffleTheDeck();
            // pino.PrintDeckSize();
            // Console.WriteLine("------------");
            // pino.PrintDeckCards();
            // Console.WriteLine("-----Random cards-------");
            // pino.DrawRandomCards(3);



        }
    }
}
