using BlackJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BlackJack_Tests
{
    [TestClass]
    public class RemoveCard_Tests
    {
        [TestMethod]
        public void Given_I_have_a_deck_size_of_3_the_new_count_should_be_2()
        {
            // Given I have a deck with a list size of 3
            // And I want to draw a card from the deck
            List<Card> cards = new List<Card>();
            cards.Add(new Card());
            cards.Add(new Card());
            cards.Add(new Card());

            // When I call the Remove Cardmethod
            IRemoveCard removeCard = new RemoveCard();
            List<Card> newCardList = removeCard.RemoveCardFromDeck(cards);

            // Then I expected the card list size is reduced to 2.
            Assert.AreEqual(2, newCardList.Count);
        }

        [TestMethod]
        public void Given_I_have_a_deck_size_of_2_the_new_count_should_be_1()
        {
            // Given I have a deck with a list size of 2
            // And I want to draw a card from the deck
            List<Card> cards = new List<Card>();
            cards.Add(new Card());
            cards.Add(new Card());

            // When I call the Remove Cardmethod
            IRemoveCard removeCard = new RemoveCard();
            List<Card> newCardList = removeCard.RemoveCardFromDeck(cards);

            // Then I expected the card list size is reduced to 1.
            Assert.AreEqual(1, newCardList.Count);
        }

        [TestMethod]
        public void Given_I_have_a_deck_size_of_1_the_new_count_should_be_0()
        {
            // Given I have a deck with a list size of 1
            // And I want to draw a card from the deck
            List<Card> cards = new List<Card>();
            cards.Add(new Card());

            // When I call the Remove Cardmethod
            IRemoveCard removeCard = new RemoveCard();
            List<Card> newCardList = removeCard.RemoveCardFromDeck(cards);

            // Then I expected the card list size is reduced to 0.
            Assert.AreEqual(0, newCardList.Count);
        }

        [TestMethod]
        public void Given_I_have_a_deck_size_of_0_the_new_count_should_still_be_0()
        {
            // Given I have a deck with a list size of 0
            // And I want to draw a card from the deck
            List<Card> cards = new List<Card>();
      
            // When I call the Remove Cardmethod
            IRemoveCard removeCard = new RemoveCard();
            List<Card> newCardList = removeCard.RemoveCardFromDeck(cards);

            // Then I expected the card list size is still 0.
            Assert.AreEqual(0, newCardList.Count);
        }

    }
}
