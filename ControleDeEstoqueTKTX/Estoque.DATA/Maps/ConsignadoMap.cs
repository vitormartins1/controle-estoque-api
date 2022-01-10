using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ConsignadoMap : IEntityTypeConfiguration<Consignado>
    {
        public void Configure(EntityTypeBuilder<Consignado> builder)
        {
            
        }
    }
}
