using System.Collections.Generic;

namespace BlackJack
{
    public interface IRemoveCard
    {
        List<Card> RemoveCardFromDeck(List<Card> cards);
    }
}
