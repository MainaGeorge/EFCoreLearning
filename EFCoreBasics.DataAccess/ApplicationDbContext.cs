using EFCoreBasics.ProjectModels.Models;
using EFCoreBasics.ProjectModels.Models.DataAnnotationsModels;
using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

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

            modelBuilder.Entity<Movie>().HasKey(p => p.MovieId);
            modelBuilder.Entity<Movie>().Property(p => p.DateReleased).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.BudgetAllocated).IsRequired()
                .HasColumnType("decimal(9,2)");
            modelBuilder.Entity<Movie>().Property(p => p.ActualBudget).IsRequired()
                .HasColumnType(typeName:"decimal(9, 2)");


            modelBuilder.Entity<Actor>().HasKey(p => p.Id);
            modelBuilder.Entity<Actor>().Property(p => p.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Actor>().Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Actor>().Ignore(p => p.FullName);
            modelBuilder.Entity<Actor>().Property(p => p.BirthDate).IsRequired();

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthorConnectionTable> BookAuthorConnectionTable { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
