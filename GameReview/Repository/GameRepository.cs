using GameReview.Data.Context;
using GameReview.Interfaces;
using GameReview.Model.Game;

namespace GameReview.Repository 
{
    public class GameRepository :IGameRepository
    {
        private readonly DataContext _context;
        public GameRepository(DataContext context)
        {
            _context = context;
        }

        public Game GetGame(int id)
        {
            return _context.Games.Where(g => g.GameID == id).FirstOrDefault();
        }

        public Game GetGame(string name)
        {
            return _context.Games.Where(g => g.GameName == name).FirstOrDefault();
        }

        public decimal GetGameRating(int gameId)
        {
            var review =  _context.Reviews.Where(rev => rev.Rating == gameId);

            if (review.Count() <= 0)
                return 0;

            return ((decimal)review.Sum(r => r.Rating) / review.Count());
        }

        public ICollection<Game> GetGame()
        {
            return _context.Games.OrderBy(g => g.GameID).ToList(); 
        }

        public bool GameExists(int gameId)
        {
            return _context.Games.Any(g => g.GameID == gameId);
        }
    }
}
