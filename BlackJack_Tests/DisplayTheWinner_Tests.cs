using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack_Tests
{
    [TestClass]
    public class DisplayTheWinner_Tests
    {
        [TestMethod]
        public void Given_the_player_has_a_score_of_10_and_dealer_has_score_of_12_dealer_wins()
        {
            // Given I have a total of 10
            // And The dealer has a list of cards with a total of 12
            var playerScore = 10;
            var dealerScore = 12;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);
            // Then I should expect the dealer has won
            Assert.AreEqual("Dealer", result);
        }

        [TestMethod]
        public void Given_the_player_has_a_score_of_12_and_dealer_has_score_of_10_player_wins()
        {
            // Given I have a total of 12
            // And The dealer has a list of cards with a total of 11
            var playerScore = 12;
            var dealerScore = 10;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);
            // Then I should expect the player has won
            Assert.AreEqual("Player", result);
        }

        [TestMethod]
        public void Given_the_player_has_a_score_of_12_and_dealer_has_score_of_21_dealer_wins()
        {
            // Given I have a total of 12
            // And The dealer has a list of cards with a total of 21
            var playerScore = 12;
            var dealerScore = 21;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);
            // Then I should expect the dealer has won
            Assert.AreEqual("Dealer", result);
        }

        [TestMethod]
        public void Given_the_player_has_a_score_of_21_and_dealer_has_score_of_21_draw()
        {
            // Given I have a total of 21
            // And The dealer has a list of cards with a total of 21
            var playerScore = 21;
            var dealerScore = 21;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);

            // Then I should expect nobody won - 'draw'
            Assert.AreEqual("Draw", result);
        }

        [TestMethod]
        public void Given_the_player_has_a_score_of_22_and_dealer_has_score_of_1_dealer()
        {
            // Given I have a total of 22
            // And The dealer has a list of cards with a total of 1
            var playerScore = 22;
            var dealerScore = 1;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);

            // Then I should expect dealer won
            Assert.AreEqual("Dealer", result);
        }
        [TestMethod]
        public void Given_the_player_has_a_score_of_1_and_dealer_has_score_of_22_player()
        {
            // Given I have a total of 1
            // And The dealer has a list of cards with a total of 22
            var playerScore = 1;
            var dealerScore = 22;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);

            // Then I should expect player won
            Assert.AreEqual("Player", result);
        }
        [TestMethod]
        public void Given_the_player_has_a_score_of_22_and_dealer_has_score_of_22_player_draw()
        {
            // Given I have a total of 22
            // And The dealer has a list of cards with a total of 22
            var playerScore = 22;
            var dealerScore = 22;

            // When the I call the win method
            ICheckWinner checkWinner = new CheckWinner();
            string result = checkWinner.CheckTheWinnerBetweenPlayerAndDealer(playerScore, dealerScore);

            // Then I should expect nobody won - 'Draw'
            Assert.AreEqual("Draw", result);
        }


    }
}


