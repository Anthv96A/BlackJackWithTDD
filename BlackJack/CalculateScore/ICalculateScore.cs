using System.Collections.Generic;

namespace BlackJack
{
    public interface ICalculateScore
    {
        int CalculateTotalCardScore(List<Card> cards);
    }
}
