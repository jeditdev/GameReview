namespace GameReview.Model.Game
{
    public class Provider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Developer { get; set; }

        public Country Country { get; set; }
        public ICollection<GameProvider> GameProviders { get; set; }
    }
}
