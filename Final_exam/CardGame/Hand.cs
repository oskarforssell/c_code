using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Hand
    {
        Deck pack = new Deck();
        public void GetPlayerHand(int cardNum)
        {
            pack.ShuffleTheDeck();
            pack.DealCards(cardNum);
            pack.PrintPlayerHand();
            pack.PrintAIHand();
        }

        public string PlayCard()
        {
            string cardRange = (pack.PlayerHandSize() - 1).ToString();
            Console.WriteLine($"Which card do you want to play? (0-{cardRange})");
            
            while (true)
            {
                int ans = Int32.Parse(Console.ReadLine());

                if (ans <= pack.PlayerHandSize() - 1 && ans > -1)
                {
                    Card single = pack.playerHand[ans];
                    Console.Write("You played the: ");
                    single.Print();
                    pack.RemoveFromPlayerHand(ans);
                    break;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{cardRange})"); }
            }
            pack.PrintPlayerHand();

            return "This_is_the_return_statement";
        }
    }
}
