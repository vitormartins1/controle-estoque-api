using Estoque.DOMAIN.Enums;
using Estoque.DOMAIN.Models;

namespace Estoque.DOMAIN.Diagrams
{
    public class Item
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual TipoItem Tipo { get; set; }
    }
}
