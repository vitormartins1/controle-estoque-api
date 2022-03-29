using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class ItemRetornado
    {
        public int Id { get; set; }
        public int VendaRetornadaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
