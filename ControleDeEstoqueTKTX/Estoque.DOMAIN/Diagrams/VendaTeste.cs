using Estoque.DOMAIN.Enums;
using System.Text.Json.Serialization;
using Estoque.DOMAIN.Diagrams;

namespace Estoque.DOMAIN.Models
{
    public class VendaTeste
    {
        public int Id { get; set; }
        public string? NumeroPedido { get; set; }
        public int ClienteId { get; set; }
        public TipoVenda TipoVenda { get; set; }
        [JsonIgnore] public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemVendaTeste> ItemVendasTeste { get; set; }
    }
}
