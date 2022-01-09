using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable(nameof(Produto))
                .HasKey(c => c.IdProduto);

            builder
                .Property(p => p.IdProduto)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.NomeProduto)
                .IsRequired();

            builder.Property(p => p.ValorProduto)
                .IsRequired();

            //builder.Property(p => p.QuantidadeEstoque)
            //    .HasColumnType("INT");

            //builder.Property(p => p.QuantidadeVendas)
            //    .HasColumnType("INT");

            builder.Property(P => P.DescricaoProduto)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(450);

        }
    }
}
