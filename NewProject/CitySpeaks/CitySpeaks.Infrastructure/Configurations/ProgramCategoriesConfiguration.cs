﻿using CitySpeaks.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CitySpeaks.Persistence.Configurations
{
    public class ProgramCategoriesConfiguration : IEntityTypeConfiguration<ProgramCategories>
    {
        public void Configure(EntityTypeBuilder<ProgramCategories> builder)
        {
            builder.HasKey(e => e.CategoryId)
                    .HasName("PK_dbo.ProgramCategories");
            builder.Property(e => e.Name).IsRequired();
        }
    }
}
