using GameReview.Model.Game;

namespace GameReview.IRepository
{
    public interface IGenreRepository
    {
        ICollection<Genre> GetGenres();
        Genre GetGenre(int id);
        ICollection<Game> GetGameByGenre(int genreId);
        bool GenreExists(int id);
    }
}
