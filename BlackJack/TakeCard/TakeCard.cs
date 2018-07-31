using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class TakeCardFromDeck : ITakeCard
    {
        public Card GetCard(List<Card> cards)
        {
            return cards.LastOrDefault();
        }
    }
}
