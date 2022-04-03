using Estoque.DATA.Maps;
using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DATA.Context
{
    public class EstoqueDbContext : DbContext
    {
        public EstoqueDbContext(
            DbContextOptions<EstoqueDbContext> options
            ) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Consignado> Consignado { get; set; }
        public DbSet<Estoque.DOMAIN.Models.Estoque> Estoque { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Lote> Lote { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Revendedor> Revendedor { get; set; }
        public DbSet<Venda> Venda { get; set; }

        // Teste
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new CompraMap());
            modelBuilder.ApplyConfiguration(new ConsignadoMap());
            modelBuilder.ApplyConfiguration(new EstoqueMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new LoteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new RevendedorMap());
            modelBuilder.ApplyConfiguration(new VendaMap());

            // Teste
            modelBuilder.ApplyConfiguration(new ItemMap());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
        }
    }
}
