using System;
using System.Collections.Generic;

namespace BlackJack.InitialiseDeck
{
    public class StartDeck : IStartDeck
    {
        private readonly IShuffleDeck shuffleDeck;

        public StartDeck(IShuffleDeck shuffleDeck)
        {
            this.shuffleDeck = shuffleDeck;
        }

        // Generate 52 cards
        public List<Card> InitialiseDeck()
        {
            List<Card> cards = new List<Card>();
         
            for(var i = 0; i < 4; i++)
            {               
                for(var j = 2; j <= 9; j++)
                {
                    cards.Add(new Card { Value = j.ToString() });
                }
                cards.Add(new Card { Value = "jack" });
                cards.Add(new Card { Value = "king" });
                cards.Add(new Card { Value = "queen" });
                cards.Add(new Card { Value = "ace" });
            }
            return shuffleDeck.ShuffledCards(cards);
        }
    }
}
