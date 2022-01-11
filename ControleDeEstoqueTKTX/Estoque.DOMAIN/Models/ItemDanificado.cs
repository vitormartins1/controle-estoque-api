using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class ItemDanificado
    {
        public int Id { get; set; }
        public int? VendaId { get; set; }
        public int? LoteId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}
