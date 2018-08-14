using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.CardValueConverter
{
    public interface IConvertCardValue
    {
        string ConvertValueFromCard(string cardValue);
    }
}
