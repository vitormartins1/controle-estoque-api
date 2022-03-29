using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ItemVendaMap : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder
                .ToTable(nameof(ItemVenda))
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(i => i.VendaId)
                .IsRequired();

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            builder
                .HasOne<Produto>()
                .WithMany()
                .HasForeignKey(i => i.ProdutoId)
                .HasConstraintName("FK_ItemVenda_Produto");
        }
    }
}