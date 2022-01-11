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
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.VendaRetornadaId)
                .IsRequired();

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            builder
                .HasOne<Produto>(i => i.Produto)
                .WithOne()
                .HasForeignKey<ItemRetornado>(i => i.ProdutoId)
                .HasConstraintName("FK_ItemRetornado_Produto");
        }
    }
}
