using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Diagrams
{
    public class ItemTeste : Item
    {
        public int Id { get; set; }
        public int VendaId { get; set; }

        public ItemTeste()
        {
            Tipo = TipoItem.SAIDA;
        }
    }
}
