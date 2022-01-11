using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class Revendedor //: Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Consignado> Consignados { get; set; }
    }
}
