using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class MoviesActorsJoiningTableConfigurations : IEntityTypeConfiguration<MoviesActorsJoiningTable>
    {
        public void Configure(EntityTypeBuilder<MoviesActorsJoiningTable> builder)
        {
            builder.HasKey(p => new {p.ActorId, p.MovieId});

            builder.HasOne(p => p.Movie)
                .WithMany(p => p.Actors)
                .HasForeignKey(p => p.MovieId);

            builder.HasOne(p => p.Actor)
                .WithMany(p => p.Movies)
                .HasForeignKey(p => p.ActorId);
        }
    }
}
