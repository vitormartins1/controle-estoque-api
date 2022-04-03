using Estoque.DOMAIN.Enums;
using System.Text.Json.Serialization;

namespace Estoque.DOMAIN.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string? NumeroPedido { get; set; }
        public int ClienteId { get; set; }
        public TipoVenda TipoVenda { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
    }
}
