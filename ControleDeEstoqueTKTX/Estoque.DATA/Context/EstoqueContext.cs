using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Context
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(
            DbContextOptions<EstoqueContext> options
            ) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<Estoque>()
            //    .Property(e => e.Name)
            //    .HasMaxLength(200);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
        }
    }
}
