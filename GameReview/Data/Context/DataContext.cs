using GameReview.Model.Game;
using Microsoft.EntityFrameworkCore;

namespace GameReview.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
        public DbSet<GameProvider> GameProviders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameGenre>()
                .HasKey(gg => new { gg.GameId, gg.GenreId });
            modelBuilder.Entity<GameGenre>()
                .HasOne(g => g.Game)
                .WithMany(gg => gg.GameGenres)
                .HasForeignKey(g => g.GameId);
            modelBuilder.Entity<GameGenre>()
                .HasOne(g => g.Genre)
                .WithMany(gg => gg.GameGenres)
                .HasForeignKey(g => g.GenreId);

            modelBuilder.Entity<GameProvider>()
                .HasKey(go => new { go.GameId, go.ProviderId });
            modelBuilder.Entity<GameProvider>()
                .HasOne(g => g.Game)
                .WithMany(gg => gg.GameProviders)
                .HasForeignKey(g => g.GameId);
            modelBuilder.Entity<GameProvider>()
                .HasOne(g => g.Provider)
                .WithMany(gg => gg.GameProviders)
                .HasForeignKey(g => g.ProviderId);
        }
    }
}
