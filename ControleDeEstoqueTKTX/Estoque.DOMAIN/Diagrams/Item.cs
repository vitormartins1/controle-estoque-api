using Estoque.DOMAIN.Enums;
using Estoque.DOMAIN.Models;
using System.Text.Json.Serialization;

namespace Estoque.DOMAIN.Diagrams
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }

        public virtual TipoItem Tipo { get; set; }
    }
}
