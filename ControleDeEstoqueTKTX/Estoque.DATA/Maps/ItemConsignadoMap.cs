using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ItemConsignadoMap : IEntityTypeConfiguration<ItemConsignado>
    {
        public void Configure(EntityTypeBuilder<ItemConsignado> builder)
        {
            builder
               .ToTable(nameof(ItemVenda));

            builder
               .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            builder
                .HasOne<Produto>(i => i.Produto)
                .WithOne()
                .HasForeignKey<ItemConsignado>(i => i.ProdutoId)
                .HasConstraintName("FK_ItemConsignado_Produto");
        }
    }
}
