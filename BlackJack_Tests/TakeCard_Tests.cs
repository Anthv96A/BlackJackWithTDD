using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BlackJack_Tests
{
    [TestClass]
    public class TakeCard_Tests
    {
        [TestMethod]
        public void Given_I_have_a_list_of_cards_the_card_return_should_have_a_value_of_5()
        {
            // Given I have a deck list of 1 and the last card value is 5
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Value = "5" });

            // When I call the return Card Method
            ITakeCard takeCard = new TakeCardFromDeck();
            var result = takeCard.GetCard(cards);

            // Then I return the card from the top of the deck.
            Assert.AreEqual("5", result.Value);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_cards_the_card_return_should_have_a_value_of_ace()
        {
            // Given I have a deck list of 2 and the last card value is ace
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "ace" });

            // When I call the return Card Method
            ITakeCard takeCard = new TakeCardFromDeck();
            var result = takeCard.GetCard(cards);

            // Then I return the card from the top of the deck.
            Assert.AreEqual("ace", result.Value);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_cards_the_card_return_should_have_a_value_of_king()
        {
            // Given I have a deck list of 4 and the last card value is king
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "ace" });
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "king" });

            // When I call the return Card Method
            ITakeCard takeCard = new TakeCardFromDeck();
            var result = takeCard.GetCard(cards);

            // Then I return the card from the top of the deck.
            Assert.AreEqual("king", result.Value);
        }

        [TestMethod]
        public void Given_I_have_a_list_of_cards_the_card_return_should_have_a_value_of_10()
        {
            // Given I have a deck list of 10 and the last card value is 10
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "ace" });
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "10" });

            // When I call the return Card Method
            ITakeCard takeCard = new TakeCardFromDeck();
            var result = takeCard.GetCard(cards);

            // Then I return the card from the top of the 10.
            Assert.AreEqual("10", result.Value);
        }


        [TestMethod]
        public void Given_I_have_a_list_of_cards_the_card_return_should_have_a_value_of_20()
        {
            // Given I have a deck list of 20 and the last card value is 2
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "ace" });
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "10" });
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "ace" });
            cards.Add(new Card() { Value = "5" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "king" });
            cards.Add(new Card() { Value = "2" });

            // When I call the return Card Method
            ITakeCard takeCard = new TakeCardFromDeck();
            var result = takeCard.GetCard(cards);

            // Then I return the card from the top of the 2.
            Assert.AreEqual("2", result.Value);
        }
    }
}
