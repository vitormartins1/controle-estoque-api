using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class EstoqueMap : 
        IEntityTypeConfiguration<Estoque.DOMAIN.Models.Estoque>
    {
        public void Configure(
            EntityTypeBuilder<Estoque.DOMAIN.Models.Estoque> builder)
        {
            builder
                .ToTable(nameof(Estoque.DOMAIN.Models.Estoque));

            builder
                .HasKey(estoque => estoque.Id);

            builder
                .Property(estoque => estoque.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
