using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class RegistroSaidaMap : IEntityTypeConfiguration<RegistroSaida>
    {
        public void Configure(EntityTypeBuilder<RegistroSaida> builder)
        {
            builder.ToTable(nameof(RegistroSaida));
        }
    }
}
