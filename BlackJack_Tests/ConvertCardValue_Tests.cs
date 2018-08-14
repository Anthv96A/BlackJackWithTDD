using System;
using BlackJack.CardValueConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack_Tests
{
    [TestClass]
    public class ConvertCardValue_Tests
    {
        [TestMethod]
        public void Given_I_have_the_card_ace_then_I_should_expect_the_value_11()
        {
            // Given I have the card value of ace
            var cardValue = "ace";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "11"
            Assert.AreEqual("11", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_king_then_I_should_expect_the_value_10()
        {
            // Given I have the card value of king
            var cardValue = "king";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "10"
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_queen_then_I_should_expect_the_value_10()
        {
            // Given I have the card value of queen
            var cardValue = "queen";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "10"
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_jack_then_I_should_expect_the_value_10()
        {
            // Given I have the card value of jack
            var cardValue = "jack";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "10"
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_2_then_I_should_expect_the_value_2()
        {
            // Given I have the card value of 2
            var cardValue = "2";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "2"
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_3_then_I_should_expect_the_value_3()
        {
            // Given I have the card value of 3
            var cardValue = "3";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "3"
            Assert.AreEqual("3", result);
        }


        [TestMethod]
        public void Given_I_have_the_card_4_then_I_should_expect_the_value_4()
        {
            // Given I have the card value of 4
            var cardValue = "4";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "4"
            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_5_then_I_should_expect_the_value_5()
        {
            // Given I have the card value of 5
            var cardValue = "5";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "5"
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_6_then_I_should_expect_the_value_6()
        {
            // Given I have the card value of 6
            var cardValue = "6";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "6"
            Assert.AreEqual("6", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_7_then_I_should_expect_the_value_7()
        {
            // Given I have the card value of 7
            var cardValue = "7";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "7"
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_8_then_I_should_expect_the_value_8()
        {
            // Given I have the card value of 8
            var cardValue = "8";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "8"
            Assert.AreEqual("8", result);
        }

        [TestMethod]
        public void Given_I_have_the_card_9_then_I_should_expect_the_value_9()
        {
            // Given I have the card value of 9
            var cardValue = "9";

            // When I pass the card value into the card converter
            IConvertCardValue convertCardValue = new ConvertCardValue();
            string result = convertCardValue.ConvertValueFromCard(cardValue);

            // Then I should expect the value to be "9"
            Assert.AreEqual("9", result);
        }


    }
}
