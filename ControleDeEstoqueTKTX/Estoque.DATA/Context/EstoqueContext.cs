using Estoque.DATA.Maps;
using Estoque.DOMAIN.Diagrams;
using Estoque.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.DATA.Context
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(
            DbContextOptions<EstoqueContext> options
            ) : base(options) { }

        //public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<Compra> Compra { get; set; }
        //public DbSet<Consignado> Consignado { get; set; }
        //public DbSet<Estoque.DOMAIN.Models.Estoque> Estoque { get; set; }
        //public DbSet<Fornecedor> Fornecedor { get; set; }
        //public DbSet<ItemConsignado> ItemConsignado { get; set;}
        //public DbSet<ItemDanificado> ItemDanificado { get; set; }
        //public DbSet<ItemEstoque> ItemEstoque { get; set; }
        //public DbSet<ItemRetornado> ItemRetornado { get; set;}
        //public DbSet<ItemVenda> ItemVenda { get; set; }
        //public DbSet<Lote> Lote { get; set; }
        public DbSet<Produto> Produto { get; set; }
        //public DbSet<Revendedor> Revendedor { get; set; }
        //public DbSet<Venda> Venda { get; set; }
        //public DbSet<VendaRetornada> VendaRetornada { get; set; }

        // Teste
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemVendaTeste> ItemVendaTeste { get; set; }
        public DbSet<VendaTeste> VendaTeste { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ClienteMap());
            //modelBuilder.ApplyConfiguration(new CompraMap());
            //modelBuilder.ApplyConfiguration(new ConsignadoMap());
            //modelBuilder.ApplyConfiguration(new EstoqueMap());
            //modelBuilder.ApplyConfiguration(new FornecedorMap());
            //modelBuilder.ApplyConfiguration(new ItemConsignadoMap());
            //modelBuilder.ApplyConfiguration(new ItemDanificadoMap());
            //modelBuilder.ApplyConfiguration(new ItemEstoqueMap());
            //modelBuilder.ApplyConfiguration(new ItemRetornadoMap());
            //modelBuilder.ApplyConfiguration(new ItemVendaMap());
            //modelBuilder.ApplyConfiguration(new LoteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            //modelBuilder.ApplyConfiguration(new RevendedorMap());
            //modelBuilder.ApplyConfiguration(new VendaMap());
            //modelBuilder.ApplyConfiguration(new VendaRetornadaMap());

            // Teste
            modelBuilder.ApplyConfiguration(new ItemMap());
            modelBuilder.ApplyConfiguration(new ItemVendaTesteMap());
            modelBuilder.ApplyConfiguration(new VendaTesteMap());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
        }
    }
}
