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
                .HasKey(v => v.Id);

            builder
                .Property(v => v.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.VendaId)
                .IsRequired();

            builder
                .HasMany<ItemRetornado>(v => v.ItemRetornados)
                .WithOne()
                .HasForeignKey(i => i.VendaRetornadaId)
                .HasConstraintName("FK_VendaRetornada_ItemRetornados");

        }
    }
}
