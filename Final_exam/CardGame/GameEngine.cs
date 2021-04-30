using System;

namespace CardGame
{
    public class GameEngine
    {
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
                        playWin = PlayCard(playWin[1]);
                    }
                    GameWinner();
                    break;
                }
            }
            void GameWinner()
            {
                Console.WriteLine("GAME OVER");
                if (hand.playerScore > hand.aiScore)
                {
                    Console.WriteLine("You are victorious! Human player wins!\n");
                }
                else
                {
                    Console.WriteLine("You loose! The AI has outsmarted you and will conquer the world!!\n");
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

        public int[] PlayCard(int playingOrder)
        {
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
                if (ans <= hand.PlayerHandSize() - 1 && ans > -1)
                {
                    int[] playerCard = Player(ans);
                    int[] aiCard = AI();
                    output[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1], playingOrder);

                    if (hand.PlayerHandSize() == 0)
                    {
                        output[0] = 0;  // End game (no more cards)
                        return output;
                    }
                    output[0] = 1;  // Continue game
                    return output;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{(hand.PlayerHandSize() - 1).ToString()})"); }
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
                if (ans <= hand.PlayerHandSize() - 1 && ans > -1)
                {
                    int[] playerCard = Player(ans);
                    output[1] = Winner(playerCard[0], aiCard[0], playerCard[1], aiCard[1], playingOrder);

                    if (hand.PlayerHandSize() == 0)
                    {
                        output[0] = 0;
                        return output;
                    }
                    output[0] = 1;
                    return output;
                }
                else { Console.WriteLine($"Hey dumdum! You have to choose between (0-{(hand.PlayerHandSize() - 1).ToString()})"); }
            }
        }
        public void GamePlayQuestion()
        {
            string cardRange = (hand.PlayerHandSize() - 1).ToString();
            if (hand.PlayerHandSize() > 1)
            {
                hand.PrintPlayerHand();
                Console.Write($"Which card do you want to play? (0-{cardRange}): ");
            }
            else if (hand.PlayerHandSize() == 1)
            {
                hand.PrintPlayerHand();
                Console.Write($"Last card to play! (0): ");
            }
        }

        public int[] Player(int ans)
        {
            Card oneCard = hand.playerHand[ans];
            Console.Write("The player chose ");
            oneCard.Print();
            string playedCard = oneCard.ReturnCard();
            int[] suitRank = new int[2] { oneCard.CardSuit(), oneCard.CardRank() };
            hand.playerHand.RemoveAt(ans);
            return suitRank;
        }
        public int[] AI()
        {
            Random random = new Random();
            int selection = random.Next(0, (hand.AIHand.Count - 1));
            Card aiCard = hand.AIHand[selection];
            Console.Write("The AI chose ");
            aiCard.Print();
            int[] suitRank = new int[2] { aiCard.CardSuit(), aiCard.CardRank() };
            hand.AIHand.RemoveAt(selection);
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
                    hand.aiScore++;
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
                    hand.playerScore++;
                    Scoreboard();
                    return 0;
                }
            }
            void PlayerWon()
            {
                Console.WriteLine("Player scored one point!\n");
                hand.playerScore++;
                Scoreboard();
            }
            void AiWon()
            {
                Console.WriteLine("AI scored one point!\n");
                hand.aiScore++;
                Scoreboard();
            }
        }
        public void Scoreboard()
        {
            Console.WriteLine("-SCOREBOARD-");
            Console.WriteLine($" Player: {hand.playerScore.ToString()}\n AI:\t {hand.aiScore.ToString()}");
            Console.WriteLine("------------------------------------\n");
        }
    }
}
