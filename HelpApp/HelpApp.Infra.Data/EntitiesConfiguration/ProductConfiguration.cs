using HelpApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpApp.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Price).HasPrecision(10, 2);
            builder.Property(p => p.Image).HasMaxLength(250).IsRequired();
            builder.Property(t => t.Stock).IsRequired();

            builder.HasOne(e => e.Category).WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno com 200 folhas",
                    Price = 9.99m,
                    Stock = 150,
                    Image = "caderno.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Fones de Ouvido",
                    Description = "Fones para Celular",
                    Price = 79.99m,
                    Stock = 25,
                    Image = "fones.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Caneta Azul",
                    Description = "Caneta para estudante cor Azul",
                    Price = 6.50m,
                    Stock = 300,
                    Image = "caneta.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Name = "Borracha",
                    Description = "Borracha estudantil",
                    Price = 2.99m,
                    Stock = 300,
                    Image = "borracha,jpg",
                    CategoryId = 4
                },
                new Product
                {
                    Id = 5,
                    Name = "Mochila",
                    Description = "Mochila para crianças",
                    Price = 99.99m,
                    Stock = 10,
                    Image = "mochila.jpg",
                    CategoryId = 5
                }
            );
        }
    }
}
