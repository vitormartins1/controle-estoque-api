using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class RevendedorMap : IEntityTypeConfiguration<Revendedor>
    {
        public void Configure(EntityTypeBuilder<Revendedor> builder)
        {
            builder
                .ToTable(nameof(Revendedor))
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder
                .Property(c => c.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(35)
                .IsRequired();
        }
    }
}
