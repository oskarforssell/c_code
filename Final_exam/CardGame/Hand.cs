using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Hand
    {
        Deck pack = new Deck();
        public int playerScore = 0;
        public int aiScore = 0;
        public void GetPlayerHand(int cardNum)
        {
            pack.ShuffleTheDeck();
            pack.DealCards(cardNum);
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
            else { Console.WriteLine($"Last card to play? Press 0"); }


            while (true)
            {
                int ans = Int32.Parse(Console.ReadLine());

                if (ans <= pack.PlayerHandSize() - 1 && ans > -1)
                {
                    Card oneCard = pack.playerHand[ans];
                    Console.Write("You played the: ");
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
                    Console.Write("AI played the: ");
                    aiCard.Print();
                    int aiSuit = aiCard.CardSuit();
                    int aiRank = aiCard.CardRank();
                    pack.RemoveFromAIHand(selection);

                    /// ADD HERE comparison: if SUIT is same, then bigger rank wins, else player wins
                    if (playerSuit == aiSuit)
                    {
                        if (playerRank > aiRank)
                        {
                            Console.WriteLine("Player Wins!");
                            playerScore++;
                        }
                        else
                        {
                            Console.WriteLine("AI Wins!");
                            aiScore++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player Wins!");
                        playerScore++;
                    }

                    if (pack.PlayerHandSize() == 0)
                    {
                        Console.WriteLine($"Player Score: {playerScore.ToString()}");
                        Console.WriteLine($"AI Score: {aiScore.ToString()}");
                        return 0;

                    }
                    Console.WriteLine($"Player Score: {playerScore.ToString()}");
                    Console.WriteLine($"AI Score: {aiScore.ToString()}");
                    return 1;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{cardRange})"); }

            }
        }
    }
}
