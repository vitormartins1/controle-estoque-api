using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estoque.DATA.Maps
{
    public class RegistroMap : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable(nameof(Registro));
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.DataDeRegistro)
                .IsRequired()
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValueSql("GETDATE()");

            builder
                .HasMany<Item>(r => r.Itens)
                .WithOne()
                .HasForeignKey(x => x.Id)
                .HasConstraintName("FK_Registro_Itens")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
