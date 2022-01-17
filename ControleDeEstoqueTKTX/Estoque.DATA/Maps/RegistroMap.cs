using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Maps
{
    public class RegistroMap : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable(nameof(Registro));

            builder
                .Property(r => r.DataDeRegistro)
                .IsRequired()
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
