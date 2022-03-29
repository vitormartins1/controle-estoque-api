namespace Estoque.DOMAIN.Models
{
    public class ItemEstoque
    {
        public int Id { get; set; }
        public int LoteId { get; set; }
        public int CompraId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
