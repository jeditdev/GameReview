using GameReview.Data.Context;
using GameReview.Interfaces;
using GameReview.IRepository;
using GameReview.Model.Game;

namespace GameReview.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private DataContext _context;
        public GenreRepository(DataContext context)
        {
            _context = context;
        }
        public bool GenreExists(int id)
        {
            return _context.Genres.Any(x => x.Id == id);
        }

        public ICollection<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenre(int id)
        {
            return _context.Genres.Where(g => g.Id == id).FirstOrDefault();
        }

        public ICollection<Game> GetGameByGenre(int genreId)
        {
            return _context.GameGenres.Where(gg => gg.GenreId == genreId).Select(g => g.Game).ToList();
        }
    }
}
