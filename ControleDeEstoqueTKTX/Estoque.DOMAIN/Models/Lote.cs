using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class Lote
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public virtual ICollection<ItemEstoque> ItemsEstoque { get; set; }
        public DateTime DataDeEntrada { get; set; }
        public DateTime DataDeBaixa { get; set; }
    }
}
