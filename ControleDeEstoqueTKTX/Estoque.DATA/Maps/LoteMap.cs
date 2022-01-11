using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class LoteMap : IEntityTypeConfiguration<Lote>
    {
        public void Configure(EntityTypeBuilder<Lote> builder)
        {
            builder
                .ToTable(nameof(Lote))
                .HasKey(l => l.Id);

            builder
                .Property(l => l.Id)
                .ValueGeneratedOnAdd();

            //builder
            //    .Property(l => l.CompraId)
            //    .IsRequired();

            builder
                .Property(l => l.DataDeEntrada)
                .IsRequired()
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasMany<ItemEstoque>(lote => lote.ItemsEstoque)
                .WithOne()
                .HasForeignKey(itemEstoque => itemEstoque.LoteId)
                .HasConstraintName("FK_Lote_ItemsEstoque")
                .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasMany<ItemEstoque>(lote => lote.ItemsEstoque)
            //    .WithOne(i => i.Lote)
            //    .HasForeignKey(itemEstoque => itemEstoque.IdLote)
            //    .HasConstraintName("FK_Lote_ItemsEstoque");

            //builder
            //    .HasOne<Compra>(l => l.Compra)
            //    .WithMany()
            //    .HasForeignKey(l => l.CompraId)
            //    .HasConstraintName("FK_Compra_Lotes");
        }
    }
}
