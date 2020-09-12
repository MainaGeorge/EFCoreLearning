using EFCoreBasics.ProjectModels;
using EFCoreBasics.ProjectModels.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasics.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }    
    }
}
    