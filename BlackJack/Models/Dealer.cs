namespace BlackJack.Models
{
    public class Dealer : AbstractPlayer
    {
        public override string PlayerChoice { get; set; } = "";
        public static int GamesWon { get; set; } = 0;

        public override int ShowGamesWon()
        {
            return GamesWon;
        }
    }
}
