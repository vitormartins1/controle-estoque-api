using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class VendaRetornada
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public virtual ICollection<ItemRetornado> ItemRetornados { get; set; }
    }
}
