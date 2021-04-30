using System;
using System.Collections.Generic;

namespace CardGame
{
    public class Hand
    {
        Deck pack = new Deck();
        List<Card> playerHand = new List<Card>();
        List<Card> AIHand = new List<Card>();

        public int playerScore = 0;
        public int aiScore = 0;
        public void Deal(int cardNum)
        {
            pack.ShuffleTheDeck();
            DealCards(cardNum);
            pack.PrintDeckSize();
        }

        public void DealCards(int cardsToBeDrawn)
        {
            for (int i = 0; i < cardsToBeDrawn; i++)
            {
                Card player_card = pack.cards[0];
                Card AI_card = pack.cards[1];
                playerHand.Add(player_card);
                AIHand.Add(AI_card);
                pack.cards.RemoveAt(0);
                pack.cards.RemoveAt(0);
            }
        }

        public int PlayerHandSize()
        {
            return playerHand.Count;
        }

        public void PrintPlayerHand()
        {
            Console.WriteLine("Your cards: ");
            for (int i = 0; i < playerHand.Count; i++)
            {
                Card one = playerHand[i];
                Console.Write($"{i.ToString()}: ");
                one.Print();
            }
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
        }

        public int[] PlayerFirst(int playingOrder)
        {
            GamePlayQuestion();
            int[] output = new int[2];
            while (true)
            {
                int ans = Int32.Parse(Console.ReadLine());
                if (ans <= PlayerHandSize() - 1 && ans > -1)
                {
                    int[] playerCard = Player(ans);
                    int[] aiCard = AI();
                    output[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1], playingOrder);

                    if (PlayerHandSize() == 0)
                    {
                        output[0] = 0;
                        return output;
                    }
                    output[0] = 1;
                    return output;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{(PlayerHandSize() - 1).ToString()})"); }
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
                if (ans <= PlayerHandSize() - 1 && ans > -1)
                {
                    int[] playerCard = Player(ans);
                    output[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1], playingOrder);

                    if (PlayerHandSize() == 0)
                    {
                        output[0] = 0;
                        return output;
                    }
                    output[0] = 1;
                    return output;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{(PlayerHandSize() - 1).ToString()})"); }
            }
        }

        public void GamePlayQuestion()
        {
            string cardRange = (PlayerHandSize() - 1).ToString();
            if (PlayerHandSize() > 1)
            {
                PrintPlayerHand();
                Console.Write($"Which card do you want to play? (0-{cardRange}): ");
            }
            else if (PlayerHandSize() == 1)
            {
                PrintPlayerHand();
                Console.Write($"Last card to play! (0): ");
            }
        }

        public int[] Player(int ans)
        {
            Card oneCard = playerHand[ans];
            Console.Write("The player chose ");
            oneCard.Print();
            string playedCard = oneCard.ReturnCard();
            int[] suitRank = new int[2] { oneCard.CardSuit(), oneCard.CardRank() };
            playerHand.RemoveAt(ans);
            return suitRank;
        }
        public int[] AI()
        {
            Random random = new Random();
            int selection = random.Next(0, (AIHand.Count - 1));
            Card aiCard = AIHand[selection];
            Console.Write("The AI chose ");
            aiCard.Print();
            int[] suitRank = new int[2] { aiCard.CardSuit(), aiCard.CardRank() };
            AIHand.RemoveAt(selection);
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
                        AiWon();
                        return 1;
                    }
                    else
                    {
                        PlayerWon();
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
                        PlayerWon();
                        return 0;
                    }
                    else
                    {
                        AiWon();
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
            void PlayerWon()
            {
                Console.WriteLine("Player scored one point!\n");
                playerScore++;
                Scoreboard();
            }
            void AiWon()
            {
                Console.WriteLine("AI scored one point!\n");
                aiScore++;
                Scoreboard();
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
