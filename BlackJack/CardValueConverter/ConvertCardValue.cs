using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.CardValueConverter
{
    public class ConvertCardValue : IConvertCardValue
    {
       public string ConvertValueFromCard(string cardValue)
       {
            if (cardValue == "jack" || cardValue == "queen" || cardValue == "king")
            {
                return "10";
            }
            if (cardValue == "ace")
            {
                return "11";
            }
            else
            {
                return cardValue;
            }
       }
    }
}
