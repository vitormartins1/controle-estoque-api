using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class ItemDanificado
    {
        public int IdItemDanificado { get; set; }
        public int? IdVenda { get; set; }
        public int? IdLote { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}
