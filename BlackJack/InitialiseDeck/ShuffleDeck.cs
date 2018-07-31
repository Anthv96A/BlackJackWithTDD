using System;
using System.Collections.Generic;

namespace BlackJack.InitialiseDeck
{
    public class ShuffleDeck : IShuffleDeck
    {
        public List<Card> ShuffledCards(List<Card> deckOfCards)
        {
            List<Card> shuffledList = new List<Card>();
            Random random = new Random();

            while (deckOfCards.Count > 0)
            {
                int index = random.Next(0, deckOfCards.Count);
                shuffledList.Add(deckOfCards[index]);
                deckOfCards.RemoveAt(index);
            }

            return shuffledList;
        }
    }
}
