using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DOMAIN.Diagrams
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder
                .ToTable(nameof(Item))
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

        }
    }
}
