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
                .HasKey(l => l.IdLote);

            builder
                .Property(l => l.IdLote)
                .ValueGeneratedOnAdd();

            builder
                .Property(l => l.IdCompra)
                .IsRequired();

            builder
                .Property(l => l.DataDeEntrada)
                .IsRequired()
                .HasColumnName("DataDeEntrada")
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasMany<ItemEstoque>(lote => lote.ItemsEstoque)
                .WithOne()
                .HasForeignKey(itemEstoque => itemEstoque.IdLote)
                .HasConstraintName("FK_Lote_ItemsEstoque");
        }
    }
}
