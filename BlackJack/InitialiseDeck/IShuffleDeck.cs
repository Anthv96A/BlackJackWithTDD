using System.Collections.Generic;

namespace BlackJack.InitialiseDeck
{
    public interface IShuffleDeck
    {
        List<Card> ShuffledCards(List<Card> deckOfCards);
    }
}
