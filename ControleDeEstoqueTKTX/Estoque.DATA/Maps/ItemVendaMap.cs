using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ItemVendaMap : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder
                .ToTable(nameof(ItemVenda))
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property<int>(i => i.IdVenda)
                .IsRequired();

            builder
                .Property<int>(i => i.IdProduto)
                .IsRequired();

            builder
                .Property<int>(i => i.Quantidade)
                .IsRequired();

            builder
                .HasOne<Produto>(i => i.Produto)
                .WithOne()
                .HasForeignKey<ItemVenda>(i => i.IdProduto)
                .HasConstraintName("FK_ItemVenda_Produto");
        }
    }
}