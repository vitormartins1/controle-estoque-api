using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get;}
        public virtual ICollection<Compra> Compras { get; set; }
    }
}
