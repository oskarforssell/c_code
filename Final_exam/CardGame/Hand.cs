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
            Console.WriteLine("---Player hand---");  // DEBUGGING
            pack.PrintPlayerHand();                 // DEBUGGING
            Console.WriteLine("---------");          // DEBUGGING

            string cardRange = (pack.PlayerHandSize() - 1).ToString();
            Console.WriteLine($"Which card do you want to play? (0-{cardRange})");
            int ans = Int32.Parse(Console.ReadLine());
            pack.RemoveFromPlayerHand(ans);



            Console.WriteLine("---Player hand---");  // DEBUGGING
            pack.PrintPlayerHand();                 // DEBUGGING
            Console.WriteLine("---------");          // DEBUGGING

            return "This_is_the_return_statement";
        }
    }
}
