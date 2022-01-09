using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .ToTable(nameof(Cliente))
                .HasKey(c => c.IdCliente);

            builder
                .Property<int>("IdCliente")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer")
                .UseIdentityColumn();

            builder
                .Property<string>("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(35)
                .IsRequired();

            //builder.HasMany(c => c.Vendas);
        }
    }
}
