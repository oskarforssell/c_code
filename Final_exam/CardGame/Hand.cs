using System;
// using System.Collections.Generic;

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
        }

        public int[] PlayCard(int playingOrder)
        {
            int[] continueGameAndRoundWinner = new int[2];

            if (playingOrder == 0)
            {
                int[] output = PlayerFirst(playingOrder);
                return output;
            }
            else
            {
                int[] output = AiFirst(playingOrder);
                return output;
            }


            // while (true)
            // {
            //     int ans = Int32.Parse(Console.ReadLine());
            //     if (ans <= pack.PlayerHandSize() - 1 && ans > -1)
            //     {
            //         if (playingOrder == 0)  // Player plays first
            //         {
            //             int[] playerCard = Player(ans);
            //             int[] aiCard = AI();
            //             continueGameAndRoundWinner[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1]);
            //         }
            //         else  // AI plays first
            //         {
            //             int[] aiCard = AI();
            //             int[] playerCard = Player(ans);
            //             continueGameAndRoundWinner[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1]);
            //         }

            //         if (pack.PlayerHandSize() == 0)
            //         {
            //             continueGameAndRoundWinner[0] = 0;
            //             return continueGameAndRoundWinner;
            //         }
            //         continueGameAndRoundWinner[0] = 1;
            //         return continueGameAndRoundWinner;
            //     }
            //     else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{cardRange})"); }
            // }
        }

        public int[] PlayerFirst(int playingOrder)
        {
            GamePlayQuestion();
            int[] output = new int[2];
            while (true)
            {
                int ans = Int32.Parse(Console.ReadLine());
                if (ans <= pack.PlayerHandSize() - 1 && ans > -1)
                {
                    int[] playerCard = Player(ans);
                    int[] aiCard = AI();
                    output[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1], playingOrder);

                    if (pack.PlayerHandSize() == 0)
                    {
                        output[0] = 0;
                        return output;
                    }
                    output[0] = 1;
                    return output;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{(pack.PlayerHandSize() - 1).ToString()})"); }
            }
        }
        public int[] AiFirst(int playingOrder)
        {
            int[] output = new int[2];
            while (true)
            {
                int[] aiCard = AI();
                GamePlayQuestion();
                int ans = Int32.Parse(Console.ReadLine());
                if (ans <= pack.PlayerHandSize() - 1 && ans > -1)
                {
                    int[] playerCard = Player(ans);
                    output[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1], playingOrder);

                    if (pack.PlayerHandSize() == 0)
                    {
                        output[0] = 0;
                        return output;
                    }
                    output[0] = 1;
                    return output;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{(pack.PlayerHandSize() - 1).ToString()})"); }
            }
        }

        public void GamePlayQuestion()
        {
            string cardRange = (pack.PlayerHandSize() - 1).ToString();
            if (pack.PlayerHandSize() > 1)
            {
                pack.PrintPlayerHand();
                Console.Write($"Which card do you want to play? (0-{cardRange}): ");
            }
            else if (pack.PlayerHandSize() == 1)
            {
                pack.PrintPlayerHand();
                Console.Write($"Last card to play! (0): ");
            }
        }

        public int[] Player(int ans)
        {
            int[] suitRank = new int[2];
            Card oneCard = pack.playerHand[ans];
            Console.Write("The player chose ");
            oneCard.Print();
            string playedCard = oneCard.ReturnCard();
            suitRank[0] = oneCard.CardSuit();
            suitRank[1] = oneCard.CardRank();
            pack.RemoveFromPlayerHand(ans);
            return suitRank;

            // public int[] MultipleReturns(int a, int b)
            // {
            //     int[] minMax = int[2];
            //     if (a > b)
            //     {
            //         minMax[0] = a;
            //         minMax[1] = b;
            //     }
            //     else
            //     {
            //         minMax[0] = b;
            //         minMax[1] = a;
            //     }
            //     return minMax;
            // }
        }
        public int[] AI()
        {
            int[] suitRank = new int[2];
            Random random = new Random();
            // int selection;
            int selection = random.Next(0, (pack.AIHandSize() - 1));
            Card aiCard = pack.AIHand[selection];
            Console.Write("The AI chose ");
            aiCard.Print();
            suitRank[0] = aiCard.CardSuit();
            suitRank[1] = aiCard.CardRank();
            pack.RemoveFromAIHand(selection);
            return suitRank;
        }

        public int Winner(int playerSuit, int aiSuit, int playerRank, int aiRank, int playingOrder)
        {
            if (playingOrder == 1) // Means AI played first
            {
                if (playerSuit == aiSuit)
                {
                    if (playerRank < aiRank)
                    {
                        Console.WriteLine("AI scored one point!\n");
                        aiScore++;
                        Scoreboard();
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Player scored one point!\n");
                        playerScore++;
                        Scoreboard();
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Player picked a card with a different suit! One point for the AI!\n");
                    aiScore++;
                    Scoreboard();
                    return 1;
                }
            }
            else
            {
                if (playerSuit == aiSuit)
                {
                    if (playerRank > aiRank)
                    {
                        Console.WriteLine("Player scored one point!\n");
                        playerScore++;
                        Scoreboard();
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("AI scored one point!\n");
                        aiScore++;
                        Scoreboard();
                        return 1;
                    }
                }
                else
                {
                    Console.WriteLine("AI picked a card with a different suit! One point for the player!\n");
                    playerScore++;
                    Scoreboard();
                    return 0;
                }
            }
        }

        public void Scoreboard()
        {
            Console.WriteLine("-SCOREBOARD-");
            Console.WriteLine($" Player: {playerScore.ToString()}\n AI:\t {aiScore.ToString()}");
            Console.WriteLine("------------------------------------\n");
        }
    }
}
