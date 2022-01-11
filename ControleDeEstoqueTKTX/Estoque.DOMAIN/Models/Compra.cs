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
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<ItemEstoque> ItemsEstoque { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; }
    }
}
