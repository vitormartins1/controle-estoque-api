using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder
                .ToTable(nameof(Venda))
                .HasKey(v => v.Id);

            builder
                .Property(v => v.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(v => v.NumeroPedido)
                .HasColumnType("VARCHAR")
                .HasMaxLength(13);

            //builder
            //    .Ignore(v => v.Cliente);

            builder
                .HasOne<Cliente>(v => v.Cliente)
                .WithMany(c => c.Vendas)
                .HasForeignKey(v => v.ClienteId)
                .HasConstraintName("FK_Cliente_Vendas");
            //.OnDelete(DeleteBehavior)

            builder
                .HasMany<ItemVenda>(venda => venda.ItemVendas)
                .WithOne()
                .HasForeignKey(itemVenda => itemVenda.VendaId)
                .HasConstraintName("FK_Venda_ItemVendas");
        }
    }
}
