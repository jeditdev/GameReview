﻿namespace GameReview.Model.Game
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<GameGenre> GameGenres { get; set; }
    }
}
