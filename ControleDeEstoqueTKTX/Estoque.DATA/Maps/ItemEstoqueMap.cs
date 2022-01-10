using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ItemEstoqueMap : IEntityTypeConfiguration<ItemEstoque>
    {
        public void Configure(EntityTypeBuilder<ItemEstoque> builder)
        {
            builder
                .ToTable(nameof(ItemEstoque))
                .HasKey(i => i.IdItemEstoque);

            builder
                .Property(i => i.IdItemEstoque)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.IdLote)
                .IsRequired();

            builder
                .Property(i => i.IdCompra)
                .IsRequired();

            builder
                .Property(i => i.IdProduto)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            builder
                .HasOne<Produto>(i => i.Produto)
                .WithOne()
                .HasForeignKey<ItemEstoque>(i => i.IdProduto)
                .HasConstraintName("FK_ItemEstoque_Produto");
        }

    }
}
