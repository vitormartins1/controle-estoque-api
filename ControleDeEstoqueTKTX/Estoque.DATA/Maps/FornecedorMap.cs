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
                .HasKey(f => f.Id);

            builder
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(f => f.NomeFornecedor)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
        }
    }
}
