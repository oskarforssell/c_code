using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Hand
    {
        Deck pack = new Deck();
        public int playerScore = 0;
        public int aiScore = 0;
        public void Deal(int cardNum)
        {
            pack.ShuffleTheDeck();
            pack.DealCards(cardNum);
            pack.PrintDeckSize();
            pack.PrintPlayerHand();
            pack.PrintAIHand();
        }

        public int PlayCard()
        {
            string cardRange = (pack.PlayerHandSize() - 1).ToString();
            if (pack.PlayerHandSize() > 1)
            {
                Console.WriteLine($"Which card do you want to play? (0-{cardRange})");
            }
            else if (pack.PlayerHandSize() == 1)
            {
                Console.WriteLine($"Last card to play! Press 0");
            }

            while (true)
            {
                int ans = Int32.Parse(Console.ReadLine());

                /// add input "h" shows hand

                if (ans <= pack.PlayerHandSize() - 1 && ans > -1)
                {
                    Card oneCard = pack.playerHand[ans];
                    Console.Write("The player chose ");
                    oneCard.Print();
                    string playedCard = oneCard.ReturnCard();
                    int playerSuit = oneCard.CardSuit();
                    int playerRank = oneCard.CardRank();

                    pack.RemoveFromPlayerHand(ans);

                    // AI selection below;
                    Random random = new Random();
                    int selection;
                    selection = random.Next(0, (pack.AIHandSize() - 1));
                    Card aiCard = pack.AIHand[selection];
                    Console.Write("The AI chose ");
                    aiCard.Print();
                    int aiSuit = aiCard.CardSuit();
                    int aiRank = aiCard.CardRank();
                    pack.RemoveFromAIHand(selection);

                    /// ADD HERE comparison: if SUIT is same, then bigger rank wins, else player wins
                    Winner(playerSuit, aiSuit, playerRank, aiRank);
                    if (pack.PlayerHandSize() == 0)
                    {
                        return 0;
                    }
                    return 1;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{cardRange})"); }
            }
        }
        public void Winner(int playerSuit, int aiSuit, int playerRank, int aiRank)
        {
            if (playerSuit == aiSuit)
            {
                if (playerRank > aiRank)
                {
                    Console.WriteLine("Player scored one point!\n");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("AI scored one point!\n");
                    aiScore++;
                }
            }
            else
            {
                Console.WriteLine("AI picked a card with a different suit! One point for the player!\n");
                playerScore++;
            }

            // if (pack.PlayerHandSize() == 0)
            // {
            Console.WriteLine("-SCOREBOARD-");
            Console.WriteLine($" Player: {playerScore.ToString()}\n AI:\t {aiScore.ToString()}");
            Console.WriteLine("------------");
            // Console.WriteLine($"AI Score: {aiScore.ToString()}");
            // }
        }
    }
}
