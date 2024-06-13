namespace GameReview.Model.Game
{
    public class Game
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public DateTime ReleasedDate { get; set; }
        
        public ICollection<Review> Reviews { get; set; }
        public ICollection<GameProvider> GameProviders { get; set; }
        public ICollection<GameGenre> GameGenres { get; set; }
    }
}
