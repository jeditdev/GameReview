using GameReview.Data.Context;
using GameReview.Model.Game;

namespace GameReview
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.GameProviders.Any())
            {
                var gameProviders = new List<GameProvider>()
                {
                    new GameProvider()
                    {
                        Game = new Game()
                        {
                            GameName = "Mobile Legends",
                            ReleasedDate = new DateTime(2016,7,14),
                            GameGenres = new List<GameGenre>()
                            {
                                new GameGenre { Genre = new Genre() { Name = "MOBA"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Mobile Legends",Text = "This game is super easy", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "John Erwin", LastName = "Dimaano" } },
                                new Review { Title="Mobile Legends", Text = "The game is great", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Swift" } },
                                new Review { Title="Mobile Legends",Text = "I give it five stars because it has a decent gameplay and fun", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Manny", LastName = "McGregor" } },
                            }
                        },
                        Provider = new Provider()
                        {
                            FirstName = "Walter ",
                            LastName = "Brown",
                            Developer = "Moonton",
                            Country = new Country()
                            {
                                Name = "Mainland China"
                            }
                        }
                    },
                    new GameProvider()
                    {
                        Game = new Game()
                        {
                            GameName = "Squirtle",
                            ReleasedDate = new DateTime(2023,9,8),
                            GameGenres = new List<GameGenre>()
                            {
                                new GameGenre { Genre = new Genre() { Name = "Basketball"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "NBA2k24", Text = "DO NOT BUY!!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "John Erwin", LastName = "Dimaano" } },
                                new Review { Title= "NBA2k24",Text = "Nobody sees this so im gay", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Lebron", LastName = "James" } },
                                new Review { Title= "NBA2k24", Text = "I'd rather buy WinRAR", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Kyrie", LastName = "Irving" } },
                            }
                        },
                        Provider = new Provider()
                        {
                            FirstName = "Walter",
                            LastName = "Brown",
                            Developer = "Visual Concepts",
                            Country = new Country()
                            {
                                Name = "New York City"
                            }
                        }
                    },
                                    new GameProvider()
                    {
                        Game = new Game()
                        {
                            GameName = "Venasuar",
                            ReleasedDate = new DateTime(1903,1,1),
                            GameGenres = new List<GameGenre>()
                            {
                                new GameGenre { Genre = new Genre() { Name = "Simulation Sports Game"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="8BP",Text = "The 8 Ball Pool was enjoyable as it is a game", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "John Erwin", LastName = "Dimaano" } },
                                new Review { Title="8 Ball Pool",Text = "Had to delete this game for some reasons.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Clarence", LastName = "Dimaano" } },
                                new Review { Title="8BP",Text = "I absolutely love playing 8 Ball Pool", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Kenjie", LastName = "Dimaano" } },
                            }
                        },
                        Provider = new Provider()
                        {
                            FirstName = "Miniclip",
                            LastName = "SA",
                            Developer = "Miniclip",
                            Country = new Country()
                            {
                                Name = "Switzerland"
                            }
                        }
                    }
                };
                dataContext.GameProviders.AddRange(gameProviders);
                dataContext.SaveChanges();
            }
        }
    }
}
