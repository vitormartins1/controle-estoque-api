using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DOMAIN.Diagrams
{
    public class VendaTesteMap : IEntityTypeConfiguration<VendaTeste>
    {
        public void Configure(EntityTypeBuilder<VendaTeste> builder)
        {
            builder.ToTable(nameof(VendaTeste))
                .HasKey(v => v.Id);

            builder
                .Property(v => v.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.NumeroPedido)
                .HasColumnType("VARCHAR")
                .HasMaxLength(13);

            builder
                .HasMany<ItemVendaTeste>(venda => venda.ItemVendasTeste)
                .WithOne()
                .HasForeignKey(itemVenda => itemVenda.VendaTesteId)
                .HasConstraintName("FK_VendaTeste_ItemVendaTeste")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
