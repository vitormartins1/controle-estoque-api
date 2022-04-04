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
        public DbSet<Item> Item { get; set; }
        public DbSet<Lote> Lote { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Revendedor> Revendedor { get; set; }
        public DbSet<Registro> RegistroEntrada { get; set; }
        public DbSet<Venda> Venda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new CompraMap());
            modelBuilder.ApplyConfiguration(new ConsignadoMap());
            modelBuilder.ApplyConfiguration(new EstoqueMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ItemMap());
            modelBuilder.ApplyConfiguration(new LoteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new RegistroMap());
            modelBuilder.ApplyConfiguration(new RevendedorMap());
            modelBuilder.ApplyConfiguration(new VendaMap());

            DataSeeding(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
        }

        private void DataSeeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasData(
                    new Produto
                    {
                        Id = 1,
                        DescricaoProduto = "Brinquedo do heroi max stell.",
                        NomeProduto = "Max Stell",
                        ValorProduto = 67
                    },
                    new Produto
                    {
                        Id = 2,
                        NomeProduto = "Hot Weels Parque dos Tubarões.",
                        DescricaoProduto = "Brinquedo de carrinhos do parque dos tubarões.",
                        ValorProduto = 189
                    },
                    new Produto
                    {
                        Id = 3,
                        NomeProduto = "Miniatura Dark Souls",
                        DescricaoProduto = "Miniatura do jogo de video game dark souls.",
                        ValorProduto = 399
                    },
                    new Produto
                    {
                        Id = 4,
                        NomeProduto = "Raquete elétrica",
                        DescricaoProduto = "Raquete para matar moscas e mosquitos.",
                        ValorProduto = 19
                    }
                );
        }
    }
}
