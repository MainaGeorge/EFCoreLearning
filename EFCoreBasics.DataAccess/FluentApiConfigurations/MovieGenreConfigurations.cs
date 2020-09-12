using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class MovieGenreConfigurations : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.ToTable("Genres");
            builder.HasKey(p => p.GenreId);
            builder.Property(p => p.GenreName)
                .HasMaxLength(50)
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
