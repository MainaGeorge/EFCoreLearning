using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class ActorConfigurations : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> modelBuilder)
        {
            modelBuilder.HasKey(p => p.Id);
            modelBuilder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Ignore(p => p.FullName);
            modelBuilder.Property(p => p.BirthDate).IsRequired();
        }
    }
}
