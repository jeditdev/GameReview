namespace GameReview.Model.Game
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Provider> Providers { get; set; }
    }
}
