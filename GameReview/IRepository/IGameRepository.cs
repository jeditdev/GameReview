using GameReview.Model.Game;

namespace GameReview.Interfaces
{
    public interface IGameRepository
    {
        ICollection<Game> GetGame();
        Game GetGame(int id);
        Game GetGame(string name);
        decimal GetGameRating(int gameId);
        bool GameExists(int gameId);
    }
}
