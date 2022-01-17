using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class RegistroDanoMap : IEntityTypeConfiguration<RegistroDano>
    {
        public void Configure(EntityTypeBuilder<RegistroDano> builder)
        {
            builder.ToTable(nameof(RegistroDano));
        }
    }
}
