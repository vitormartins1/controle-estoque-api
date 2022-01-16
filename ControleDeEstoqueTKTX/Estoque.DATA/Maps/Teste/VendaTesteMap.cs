using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DOMAIN.Diagrams
{
    public class VendaTesteMap : IEntityTypeConfiguration<VendaTeste>
    {
        public void Configure(EntityTypeBuilder<VendaTeste> builder)
        {
            builder.ToTable(nameof(VendaTeste));
        }
    }
}
