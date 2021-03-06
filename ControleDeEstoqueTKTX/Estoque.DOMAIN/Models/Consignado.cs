using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class Consignado
    {
        public int Id { get; set; }
        public int RevendedorId { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
        public DateTime DataDeRegistro { get; set; }
    }
}
