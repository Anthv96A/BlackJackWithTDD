using BlackJack.CardValueConverter;
using BlackJack.ConvertString;
using BlackJack.InitialiseDeck;
using BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BlackJack
{
    public class Program
    {
        private static Random r = new Random();
        private static Dealer dealer;
        private static Player player; 

        private static IStartDeck startDeck = new StartDeck(new ShuffleDeck());
        private static IRemoveCard removeCard = new RemoveCard();
        private static IBust bust = new Bust();
        private static ITakeCard takeCard = new TakeCardFromDeck();
        private static ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
        private static ICheckWinner checkWinner = new CheckWinner();

        private static bool isPlayersTurn = (r.Next(0,4) > 2) ? true : false;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackJack, press any key to start playing!");
            Console.ReadLine();
            Console.Clear();
            StartGame();
        }

        private static void StartGame()
        {
            Console.Clear();
            dealer = new Dealer();
            player = new Player();
            List<Card> deckOfCards = startDeck.InitialiseDeck();

            if (isPlayersTurn)
            {
                Console.WriteLine("Player to go first");
            }
            else
            {
                Console.WriteLine("Dealer to go first");
            }

            while (!player.HasStuck || !dealer.HasStuck)
            {
                if (isPlayersTurn)
                {
                    Console.WriteLine("Would you like to stick or twist? (S/T)");
                    player.PlayerChoice = Console.ReadLine();

                    if (player.PlayerChoice.ToUpper() == "T")
                    {
                        Console.WriteLine("Player Twists");
                        Card dealtCard = takeCard.GetCard(deckOfCards);
                        Console.WriteLine("Dealt card of: " + dealtCard.Value);

                        player.AddCardToHand(dealtCard);
                        deckOfCards = removeCard.RemoveCardFromDeck(deckOfCards);

                        player.TotalScore = calculateScore.CalculateTotalCardScore(player.CardsInHand());
                        Console.WriteLine("Current Player Score is: " + player.TotalScore);

                        if (bust.IsBust(player.TotalScore))
                        {
                            Console.WriteLine("Player, you are bust :(");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player Sticks");
                        if (!dealer.HasStuck)
                        {
                            Console.WriteLine("Dealer's turn");
                        }

                        player.HasStuck = true;
                        isPlayersTurn = !isPlayersTurn;
                    }

                }
                else
                {
                    Random random = new Random();
                    var i = random.Next(0, 10);
                    Thread.Sleep(2500);

                    var chance = 0.9;

                    if (dealer.TotalScore >= 18)
                    {
                        chance = 5;
                    }

                    if (i > chance)
                    {
                        Console.WriteLine("Dealer Twists");
                        Card dealtCard = takeCard.GetCard(deckOfCards);
                        Console.WriteLine("Dealt card of: " + dealtCard.Value);

                        dealer.AddCardToHand(dealtCard);
                        deckOfCards = removeCard.RemoveCardFromDeck(deckOfCards);
                        dealer.TotalScore = calculateScore.CalculateTotalCardScore(dealer.CardsInHand());

                        Console.WriteLine("Current Dealer Score is: " + dealer.TotalScore);

                        if (dealer.TotalScore == 21)
                        {
                            Console.WriteLine("Dealer Twists");
                            break;
                        }

                        if (bust.IsBust(dealer.TotalScore))
                        {
                            Console.WriteLine("Dealer, you are bust :(");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dealer Sticks");
                        if (!player.HasStuck)
                        {
                            Console.WriteLine("Player's turn");
                        }
                        dealer.HasStuck = true;
                        isPlayersTurn = !isPlayersTurn;
                    }

                }
            }

            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(player.TotalScore, dealer.TotalScore);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Result");
            Console.WriteLine("The result of the game is " + result);

            switch (result)
            {
                case "Dealer":
                    Dealer.GamesWon++;
                    break;
                case "Player":
                    Player.GamesWon++;
                    break;
            }

            Console.WriteLine("Games won from dealer: " + dealer.ShowGamesWon());
            Console.WriteLine("Games won from player: " + player.ShowGamesWon());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Would you like to play again? (Y/N)");
            string choice = Console.ReadLine().ToUpper();
            
            if(choice == "Y")
            {
                StartGame();
            }

        }

    }
}
