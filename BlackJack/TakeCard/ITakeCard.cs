using System.Collections.Generic;

namespace BlackJack
{
    public interface ITakeCard
    {
        Card GetCard(List<Card> cards);
    }
}
