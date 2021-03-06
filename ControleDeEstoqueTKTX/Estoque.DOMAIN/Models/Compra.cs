using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public string? Invoice { get; set; }
        public int FornecedorId { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
        public DateTime DataDeCompra { get; set; }
    }
}
