using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder
                .ToTable(nameof(Fornecedor))
                .HasKey(f => f.FornecedorId);

            builder
                .Property(f => f.FornecedorId)
                .ValueGeneratedOnAdd();

            builder
                .Property(f => f.NomeFornecedor)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
        }
    }
}
