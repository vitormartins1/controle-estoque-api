using Estoque.DATA.Maps;
using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DATA.Context
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(
            DbContextOptions<EstoqueContext> options
            ) : base(options) { }

        public DbSet<Compra> Venda { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<ItemVenda> ItemVenda { get; set; }
        //public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendaMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ItemVendaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
        }
    }
}
