using BlackJack.CardValueConverter;
using BlackJack.ConvertString;
using System.Collections.Generic;

namespace BlackJack
{
    public class CalculateScore : ICalculateScore
    {
        private readonly IConvertCardValue convertCardValue;
        private readonly IConvertStringToInt convertStringToInt;

        public CalculateScore(IConvertCardValue convertCardValue, IConvertStringToInt convertStringToInt)
        {
            this.convertCardValue = convertCardValue;
            this.convertStringToInt = convertStringToInt;
        }

        public int CalculateTotalCardScore(List<Card> cards)
        {
            int score = 0;

            cards.ForEach(card =>
            {              
                 score += convertStringToInt.ConvertValue(convertCardValue.ConvertValueFromCard(card.Value)); 
            });

            return score;
        }
    }
}
