using System.Collections.Generic;

namespace BlackJack
{
    public abstract class AbstractPlayer
    {
        protected List<Card> PlayerCards { get; set; }

        public bool HasStuck { get; set; } = false;
        public int TotalScore { get; set; } = 0;
        public abstract string PlayerChoice { get; set; }


        public AbstractPlayer()
        {
            PlayerCards = new List<Card>();
        }

        public void AddCardToHand(Card card)
        {
            PlayerCards.Add(card);
        }

        public int CardsInHandCount()
        {
            return PlayerCards.Count;
        }

        public List<Card> CardsInHand()
        {
            return PlayerCards;
        }

        public abstract int ShowGamesWon();

    }
}
