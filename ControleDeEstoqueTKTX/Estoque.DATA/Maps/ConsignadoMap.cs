using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ConsignadoMap : IEntityTypeConfiguration<Consignado>
    {
        public void Configure(EntityTypeBuilder<Consignado> builder)
        {
            builder
                .ToTable(nameof(Consignado));

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .HasOne<Revendedor>()
                .WithMany(r => r.Consignados)
                .HasForeignKey(c => c.RevendedorId)
                .HasConstraintName("FK_Revendedor_Consignados");

            builder
                .HasMany<Item>(x => x.Itens)
                .WithOne()
                .HasForeignKey(x => x.Id)
                .HasConstraintName("FK_Consignado_ItemConsignados");
        }
    }
}
