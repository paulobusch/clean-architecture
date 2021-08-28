using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .HasMaxLength(200);

            builder.Property(p => p.Price)
                .HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno espiral com 100 folhas",
                    Price = 9.45m
                },
                new Product
                {
                    Id = 2,
                    Name = "Borracha",
                    Description = "Borracha branca pequena",
                    Price = 3.75m
                }
            );
        }
    }
}
