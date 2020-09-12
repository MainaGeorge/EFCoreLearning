using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class MovieConfigurations : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> modelBuilder)
        {
            modelBuilder.HasKey(p => p.MovieId);
            modelBuilder.Property(p => p.DateReleased).IsRequired();
            modelBuilder.Property(p => p.BudgetAllocated).IsRequired()
                .HasColumnType("decimal(9,2)");
            modelBuilder.Property(p => p.ActualBudget).IsRequired()
                .HasColumnType(typeName: "decimal(9, 2)");


            modelBuilder.HasOne(p => p.Title)
                .WithOne(m => m.Movie)
                .HasForeignKey<Movie>(p => p.TitleId);
        }
    }
}
