using System.Collections.Generic;

namespace BlackJack
{
    public class RemoveCard : IRemoveCard
    {
        public List<Card> RemoveCardFromDeck(List<Card> cards)
        {
            if(cards.Count == 0)
            {
                return cards;
            }

            cards.RemoveAt(cards.Count - 1);
            return cards;
        }
    }
}
