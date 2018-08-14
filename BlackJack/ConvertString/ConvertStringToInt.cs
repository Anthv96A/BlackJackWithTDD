using System;

namespace BlackJack.ConvertString
{
    public class ConvertStringToInt : IConvertStringToInt
    {
        public int ConvertValue(string value)
        {
            return Convert.ToInt32(value);
        }
    }
}
