namespace BlackJack
{
    public class CheckWinner : ICheckWinner
    {
        public string CheckTheWinnerBetweenPlayerAndDealer(int playerScore, int dealerScore)
        {
            if(playerScore == dealerScore || (dealerScore >= 22 && playerScore >= 22))
            {
                return "Draw";
            }

            if (dealerScore >= 22)
            {
                return "Player";
            }

            if (playerScore >= 22)
            {
                return "Dealer";
            }

            return (dealerScore > playerScore) ? "Dealer" : "Player";
        }
    }
}
