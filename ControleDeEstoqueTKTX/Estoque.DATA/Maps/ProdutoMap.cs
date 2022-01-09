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

            //builder.Property<string>(p => p.NomeProduto)
            //    .IsRequired()
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(50);

            //builder.Property<double>(p => p.ValorProduto)
            //    .IsRequired()
            //    .HasColumnType("DOUBLE")
            //    .HasMaxLength(9999999);

            //builder.Property<int>(p => p.QuantidadeEstoque)
            //    .HasColumnType("INT");

            //builder.Property<int>(p => p.QuantidadeVendas)
            //    .HasColumnType("INT");

            //builder.Property<string>(P => P.DescricaoProduto)
            //    .IsRequired()
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(450);

        }
    }
}
