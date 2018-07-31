namespace BlackJack
{
    public class Bust : IBust
    {
        public bool IsBust(int score)
        {
            return (score > 21) ? true : false;
        }
    }
}
