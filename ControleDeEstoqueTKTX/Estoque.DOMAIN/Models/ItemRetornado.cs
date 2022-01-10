using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class ItemRetornado
    {
        public int IdItemRetornado { get; set; }
        public int IdVendaRetornada { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}
