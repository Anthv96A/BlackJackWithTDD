using BlackJack;
using BlackJack.CardValueConverter;
using BlackJack.ConvertString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace BlackJack_Tests
{
    [TestClass]
    public class CalculateScoreFlow_Tests
    {

        [TestMethod]
        public void Given_I_have_1_card_the_card_value_converter_should_be_only_called_once()
        {
            // Given I have one card
            // And I call the convertCardValueMock value converter
            // And I call the convertCardValueMock string converter
            List<Card> cards = new List<Card>
            {
                new Card()
            };
            
            Mock<IConvertCardValue> convertCardValueMock = new Mock<IConvertCardValue>();
            Mock<IConvertStringToInt> convertStringToIntMock = new Mock<IConvertStringToInt>();

            // When I pass in the convertCardValueMock object
            // And call the CalculateTotalCardScore method
            ICalculateScore calculateScore = new CalculateScore(convertCardValueMock.Object, convertStringToIntMock.Object);
            calculateScore.CalculateTotalCardScore(cards);

            // Then I verify then card value converter is only called once.
            convertCardValueMock.Verify(m => m.ConvertValueFromCard(It.IsAny<string>()), Times.Once);
            // And I verify the string to int converter is only ever called once.
            convertStringToIntMock.Verify(m => m.ConvertValue(It.IsAny<string>()),Times.Once);

        }



        [TestMethod]
        public void Given_I_have_2_cards_the_card_value_converter_should_be_only_called_twice()
        {
            // Given I have two cards
            // And I call the convertCardValueMock value converter
            // And I call the convertCardValueMock string converter
            List<Card> cards = new List<Card>
            {
                new Card(),
                new Card()
            };

            Mock<IConvertCardValue> convertCardValueMock = new Mock<IConvertCardValue>();
            Mock<IConvertStringToInt> convertStringToIntMock = new Mock<IConvertStringToInt>();

            // When I pass in the convertCardValueMock object
            // And call the CalculateTotalCardScore method
            ICalculateScore calculateScore = new CalculateScore(convertCardValueMock.Object, convertStringToIntMock.Object);
            calculateScore.CalculateTotalCardScore(cards);

            // Then I verify then card value converter is only called twice.
            convertCardValueMock.Verify(m => m.ConvertValueFromCard(It.IsAny<string>()), Times.Exactly(2));
            // And I verify the string to int converter is only ever called twice.
            convertStringToIntMock.Verify(m => m.ConvertValue(It.IsAny<string>()), Times.Exactly(2));
        }


        [TestMethod]
        public void Given_I_have_3_cards_the_card_value_converter_should_be_only_called_three_times()
        {
            // Given I have three cards
            // And I call the convertCardValueMock value converter
            // And I call the convertCardValueMock string converter
            List<Card> cards = new List<Card>
            {
                new Card(),
                new Card(),
                new Card()
            };

            Mock<IConvertCardValue> convertCardValueMock = new Mock<IConvertCardValue>();
            Mock<IConvertStringToInt> convertStringToIntMock = new Mock<IConvertStringToInt>();

            // When I pass in the convertCardValueMock object
            // And call the CalculateTotalCardScore method
            // And I call the convertCardValueMock string converter
            ICalculateScore calculateScore = new CalculateScore(convertCardValueMock.Object, convertStringToIntMock.Object);
            calculateScore.CalculateTotalCardScore(cards);

            // Then I verify then card value converter is only called three times.
            convertCardValueMock.Verify(m => m.ConvertValueFromCard(It.IsAny<string>()), Times.Exactly(3));
            // And I verify the string to int converter is only ever called three times.
            convertStringToIntMock.Verify(m => m.ConvertValue(It.IsAny<string>()), Times.Exactly(3));
        }

        [TestMethod]
        public void Given_I_have_4_cards_the_card_value_converter_should_be_only_called_four_times()
        {
            // Given I have four cards
            // And I call the convertCardValueMock value converter
            // And I call the convertCardValueMock string converter
            List<Card> cards = new List<Card>
            {
                new Card(),
                new Card(),
                new Card(),
                new Card()
            };

            Mock<IConvertCardValue> convertCardValueMock = new Mock<IConvertCardValue>();
            Mock<IConvertStringToInt> convertStringToIntMock = new Mock<IConvertStringToInt>();

            // When I pass in the convertCardValueMock object
            // And call the CalculateTotalCardScore method
            // And I call the convertCardValueMock string converter
            ICalculateScore calculateScore = new CalculateScore(convertCardValueMock.Object, convertStringToIntMock.Object);
            calculateScore.CalculateTotalCardScore(cards);

            // Then I verify then card value converter is only called four times.
            convertCardValueMock.Verify(m => m.ConvertValueFromCard(It.IsAny<string>()), Times.Exactly(4));
            // And I verify the string to int converter is only ever called four times.
            convertStringToIntMock.Verify(m => m.ConvertValue(It.IsAny<string>()), Times.Exactly(4));
        }

        [TestMethod]
        public void Given_I_have_5_cards_the_card_value_converter_should_be_only_called_five_times()
        {
            // Given I have five cards
            // And I call the convertCardValueMock value converter
            // And I call the convertCardValueMock string converter
            List<Card> cards = new List<Card>
            {
                new Card(),
                new Card(),
                new Card(),
                new Card(),
                new Card()
            };

            Mock<IConvertCardValue> convertCardValueMock = new Mock<IConvertCardValue>();
            Mock<IConvertStringToInt> convertStringToIntMock = new Mock<IConvertStringToInt>();

            // When I pass in the convertCardValueMock object
            // And call the CalculateTotalCardScore method
            ICalculateScore calculateScore = new CalculateScore(convertCardValueMock.Object, convertStringToIntMock.Object);
            calculateScore.CalculateTotalCardScore(cards);

            // Then I verify then card value converter is only called five times.
            convertCardValueMock.Verify(m => m.ConvertValueFromCard(It.IsAny<string>()), Times.Exactly(5));
            // And I verify the string to int converter is only ever called five times.
            convertStringToIntMock.Verify(m => m.ConvertValue(It.IsAny<string>()), Times.Exactly(5));
        }

    }
}
