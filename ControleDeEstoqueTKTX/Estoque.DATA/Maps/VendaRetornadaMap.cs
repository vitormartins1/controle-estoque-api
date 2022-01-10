using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Estoque.DATA.Maps
{
    internal class VendaRetornadaMap : IEntityTypeConfiguration<VendaRetornada>
    {
        public void Configure(EntityTypeBuilder<VendaRetornada> builder)
        {
            builder
                .ToTable(nameof(VendaRetornada))
                .HasKey(v => v.IdVendaRetornada);

            builder
                .Property(v => v.IdVendaRetornada)
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.IdVenda)
                .IsRequired();

            builder
                .HasMany<ItemRetornado>(v => v.ItemRetornados)
                .WithOne()
                .HasForeignKey(i => i.IdVendaRetornada)
                .HasConstraintName("FK_VendaRetornada_ItemRetornados");

        }
    }
}
