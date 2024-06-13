namespace GameReview.Model.Game
{
    public class GameProvider
    {
        public int GameId { get; set; }
        public int ProviderId { get; set; }


        public Game Game { get; set; }
        public Provider Provider { get; set; }
    }
}
