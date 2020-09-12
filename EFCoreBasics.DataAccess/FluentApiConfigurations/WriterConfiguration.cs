using System;
using System.Collections.Generic;
using System.Text;
using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class WriterConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(p => p.LastName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(p => p.BirthDate)
                .IsRequired();
        }
    }
}
