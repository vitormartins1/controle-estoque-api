using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Estoque.DATA.Maps
{
    public class ItemRetornadoMap : IEntityTypeConfiguration<ItemRetornado>
    {
        public void Configure(EntityTypeBuilder<ItemRetornado> builder)
        {
            builder
                .ToTable(nameof(ItemRetornado))
                .HasKey(i => i.IdItemRetornado);

            builder
                .Property(i => i.IdItemRetornado)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.IdVendaRetornada)
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
                .HasForeignKey<ItemRetornado>(i => i.IdProduto)
                .HasConstraintName("FK_ItemRetornado_Produto");
        }
    }
}
