using Estoque.DOMAIN.Enums;
using Estoque.DOMAIN.Models;
using System.Text.Json.Serialization;

namespace Estoque.DOMAIN.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public virtual TipoItem Tipo { get; set; }
    }
}
