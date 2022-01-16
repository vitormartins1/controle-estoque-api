using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Diagrams
{
    public class ItemVendaTesteMap : IEntityTypeConfiguration<ItemVendaTeste>
    {
        public void Configure(EntityTypeBuilder<ItemVendaTeste> builder)
        {
            builder.ToTable(nameof(ItemVendaTeste));

            //builder
            //    .HasOne<Produto>(i => i.Produto)
            //    .WithOne()
            //    .HasForeignKey<ItemVendaTeste>(i => i.ProdutoId)
            //    .HasConstraintName("FK_ItemVendaTeste_Produto");
        }

    }
}
