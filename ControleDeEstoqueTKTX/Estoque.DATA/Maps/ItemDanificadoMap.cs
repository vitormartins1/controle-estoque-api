using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ItemDanificadoMap : IEntityTypeConfiguration<ItemDanificado>
    {
        public void Configure(EntityTypeBuilder<ItemDanificado> builder)
        {
            builder
                .ToTable(nameof(ItemDanificado))
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
                .HasForeignKey<ItemDanificado>(i => i.ProdutoId)
                .HasConstraintName("FK_ItemDanificado_Produto");
        }
    }
}
