using System;
using System.Collections.Generic;
using BlackJack;
using BlackJack.CardValueConverter;
using BlackJack.ConvertString;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BlackJack_Tests
{
    [TestClass]
    public class CalculateScore_Tests
    {
        [TestMethod]
        public void Given_I_have_one_card_with_the_value_of_5_I_expect_the_value_returned_is_5()
        {
            // Given I have 1 card
            // And the values are 5
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 5.
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Given_I_have_two_cards_with_the_value_of_5_and_7_I_expect_the_value_returned_is_12()
        {
            // Given I have 2 cards
            // And the values are 5 & 7
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },

                new Card
                {
                    Value = "7"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 12.
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Given_I_have_two_cards_with_the_value_of_5_and_Jack_I_expect_the_value_returned_is_15()
        {
            // Given I have 2 cards
            // And the values are 5 and jack
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },

                new Card
                {
                    Value = "jack"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 15.
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Given_I_have_two_cards_with_the_value_of_5_and_Queen_I_expect_the_value_returned_is_15()
        {
            // Given I have 2 cards
            // And the values are 5 and Queen
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },

                new Card
                {
                    Value = "queen"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 15.
            Assert.AreEqual(15, result);
        }


        [TestMethod]
        public void Given_I_have_two_cards_with_the_value_of_5_and_King_I_expect_the_value_returned_is_15()
        {
            // Given I have 2 cards
            // And the values are 5 and King
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },

                new Card
                {
                    Value = "king"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);
            // Then I should expected the values to be 15.
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Given_I_have_three_cards_with_the_value_of_5_7_and_10_I_expect_the_value_returned_is_22()
        {
            // Given I have 3 cards
            // And the values are 5, 7 and 10
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "7"
                },
                new Card
                {
                    Value = "10"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 22.
            Assert.AreEqual(22, result);
        }


        [TestMethod]
        public void Given_I_have_three_cards_with_the_value_of_5_3_and_King_I_expect_the_value_returned_is_18()
        {
            // Given I have 3 cards
            // And the values are 5, 3 and king
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "3"
                },
                new Card
                {
                    Value = "king"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 18.
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void Given_I_have_three_cards_with_the_value_of_5_3_and_Jack_I_expect_the_value_returned_is_18()
        {
            // Given I have 3 cards
            // And the values are 5, 3 and jack
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "3"
                },
                new Card
                {
                    Value = "jack"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 18.
            Assert.AreEqual(18, result);
        }


        [TestMethod]
        public void Given_I_have_three_cards_with_the_value_of_5_3_and_Queen_I_expect_the_value_returned_is_18()
        {
            // Given I have 3 cards
            // And the values are 5, 3 and queen
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "3"
                },
                new Card
                {
                    Value = "queen"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 18.
            Assert.AreEqual(18, result);
        }


        [TestMethod]
        public void Given_I_have_three_cards_with_the_value_of_5_3_and_Ace_I_expect_the_value_returned_is_19()
        {
            // Given I have 3 cards
            // And the values are 5, 3 and Ace
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "3"
                },
                new Card
                {
                    Value = "ace"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 19.
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void Given_I_have_four_cards_with_the_value_of_5_3_6_and_4_I_expect_the_value_returned_is_18()
        {
            // Given I have 4 cards
            // And the values are 5, 3, 6 and 4
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "3"
                },
                new Card
                {
                    Value = "6"
                },
                new Card
                {
                    Value = "4"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 18.
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void Given_I_have_five_cards_with_the_value_of_5_3_6_4_and_3_I_expect_the_value_returned_is_21()
        {
            // Given I have 5 cards
            // And the values are 5, 3, 6, 4 and 3
            List<Card> cards = new List<Card>()
            {
                new Card
                {
                    Value = "5"
                },
                new Card
                {
                    Value = "3"
                },
                new Card
                {
                    Value = "6"
                },
                new Card
                {
                    Value = "4"
                },
                new Card
                {
                    Value = "3"
                }
            };

            // When I call the calculator score method with list of cards
            // And I pass in a card value converter
            ICalculateScore calculateScore = new CalculateScore(new ConvertCardValue(), new ConvertStringToInt());
            int result = calculateScore.CalculateTotalCardScore(cards);

            // Then I should expected the values to be 21.
            Assert.AreEqual(21, result);
        }
    }
}
