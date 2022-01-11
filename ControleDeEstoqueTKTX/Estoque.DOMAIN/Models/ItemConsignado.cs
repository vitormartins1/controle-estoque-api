namespace Estoque.DOMAIN.Models
{
    public class ItemConsignado
    {
        public int Id { get; set; }
        public int ConsignadoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}
