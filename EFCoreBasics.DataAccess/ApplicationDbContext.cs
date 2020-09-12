using EFCoreBasics.DataAccess.FluentApiConfigurations;
using EFCoreBasics.ProjectModels.Models.DataAnnotationsModels;
using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasics.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthorConnectionTable>().HasKey(k => new {k.AuthorId, k.BookId});

            modelBuilder.ApplyConfiguration(new MovieConfigurations());
            modelBuilder.ApplyConfiguration(new WriterConfiguration());
            modelBuilder.ApplyConfiguration(new ActorConfigurations());
            modelBuilder.ApplyConfiguration(new TitleConfigurations());
            modelBuilder.ApplyConfiguration(new MovieGenreConfigurations());
            modelBuilder.ApplyConfiguration(new MoviesActorsJoiningTableConfigurations());

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthorConnectionTable> BookAuthorConnectionTable { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
