using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
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

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();

            builder
                .HasOne<Produto>()
                .WithMany()
                .HasForeignKey(i => i.ProdutoId)
                .HasConstraintName("FK_Item_Produto");

        }
    }
}
