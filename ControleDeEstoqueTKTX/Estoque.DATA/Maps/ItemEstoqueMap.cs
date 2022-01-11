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
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.LoteId)
                .IsRequired();

            builder
                .Property(i => i.CompraId)
                .IsRequired();

            builder
                .Property(i => i.Produto)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            builder
                .HasOne<Produto>(i => i.Produto)
                .WithOne()
                .HasForeignKey<ItemEstoque>(i => i.ProdutoId)
                .HasConstraintName("FK_ItemEstoque_Produto");

            //builder
            //    .HasOne<Lote>(i => i.Lote)
            //    .WithMany(l => l.ItemsEstoque)
            //    .HasForeignKey(i => i.IdLote)
            //    .HasConstraintName("FK_Lote_ItemsEstoque");
        }

    }
}
