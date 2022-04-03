using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class RegistroEntradaMap : IEntityTypeConfiguration<RegistroEntrada>
    {
        public void Configure(EntityTypeBuilder<RegistroEntrada> builder)
        {
            builder.ToTable(nameof(RegistroEntrada));
        }
    }
}
