namespace Estoque.DOMAIN.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        //public int QuantidadeEstoque { get; set; }
        //public int QuantidadeVendas { get; set; }
        public string DescricaoProduto { get; set; }
    }
}
