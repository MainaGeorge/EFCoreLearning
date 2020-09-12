using System;
using System.Collections.Generic;
using System.Text;
using EFCoreBasics.ProjectModels.Models.FluentApiModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBasics.DataAccess.FluentApiConfigurations
{
    public class ProductionCompanyConfigurations : IEntityTypeConfiguration<ProducingCompany>
    {
        public void Configure(EntityTypeBuilder<ProducingCompany> builder)
        {
            builder.ToTable("MovieProducers");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.Property(p => p.Location)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            builder.HasMany(p => p.MoviesProduced)
                .WithOne(p => p.ProducingCompany)
                .HasForeignKey(p => p.ProducingCompanyId);

        }
    }
}
