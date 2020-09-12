using System;
using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class TitleConfigurations : IEntityTypeConfiguration<Title>

    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(p => p.TitleId);
            builder.Property(p => p.Name).HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
