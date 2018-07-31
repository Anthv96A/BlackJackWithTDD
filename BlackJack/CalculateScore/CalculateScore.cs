using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class CalculateScore : ICalculateScore
    {
        public int CalculateTotalCardScore(List<Card> cards)
        {
            int score = 0;
            cards.ForEach(card =>
            {
                if(card.Value.StartsWith("j") || card.Value.StartsWith("q") || card.Value.StartsWith("k"))
                {
                    score += 10;
                }
                else if (card.Value.StartsWith("a"))
                {
                    score += 11;
                }
                else
                {
                    score += Convert.ToInt32(card.Value);
                }
            });

            return score;
        }
    }
}
