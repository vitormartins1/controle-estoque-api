using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class ItemConsignadoMap : IEntityTypeConfiguration<ItemConsignado>
    {
        public void Configure(EntityTypeBuilder<ItemConsignado> builder)
        {
            
        }
    }
}
