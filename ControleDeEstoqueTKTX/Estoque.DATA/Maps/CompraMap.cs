using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class CompraMap : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder
                .ToTable(nameof(Compra))
                .HasKey(c => c.CompraId);

            builder
                .Property(c => c.CompraId)
                .ValueGeneratedOnAdd();

            builder
                .Property(c => c.Invoice)
                .HasColumnType("VARCHAR")
                .HasMaxLength(43);

            builder
                .HasOne<Fornecedor>(c => c.Fornecedor)
                .WithMany(f => f.Compras)
                .HasForeignKey(c => c.IdFornecedor)
                .HasConstraintName("FK_Fornecedor_Compras");
            //.OnDelete(DeleteBehavior)

            builder
                .HasMany<ItemEstoque>(compra => compra.ItemsEstoque)
                .WithOne()
                .HasForeignKey(itemEstoque => itemEstoque.IdCompra)
                .HasConstraintName("FK_Compra_ItemsEstoque");

            builder
                .HasMany<Lote>(compra => compra.Lotes)
                .WithOne(lote => lote.Compra)
                .HasForeignKey(lote => lote.CompraId)
                .HasConstraintName("FK_Compra_Lotes");
        }
    }
}
