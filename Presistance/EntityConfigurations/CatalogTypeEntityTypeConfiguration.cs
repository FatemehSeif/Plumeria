﻿using Domain.Catalogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistance.EntityConfigurations
{
    public class CatalogTypeEntityTypeConfiguration : IEntityTypeConfiguration<CatalogType>
    {
        public void Configure(EntityTypeBuilder<CatalogType> builder)
        {
            builder.ToTable("CatalogType");
            builder.Property(ct => ct.Type)
                .IsRequired()
                .HasMaxLength(100);

        }

    }

    public class CatalogItemEntityTypeConfiguration
        : IEntityTypeConfiguration<CatalogItem>
    {
        public void Configure(EntityTypeBuilder<CatalogItem> builder)
        {

            builder.Property(cb => cb.Slug)
                     .HasMaxLength(900)
                     .IsUnicode();
        }
    }
}
