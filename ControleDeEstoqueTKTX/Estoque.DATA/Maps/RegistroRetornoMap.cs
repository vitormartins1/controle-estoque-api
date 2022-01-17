using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class RegistroRetornoMap : IEntityTypeConfiguration<RegistroRetorno>
    {
        public void Configure(EntityTypeBuilder<RegistroRetorno> builder)
        {
            builder.ToTable(nameof(RegistroRetorno));
        }
    }
}
