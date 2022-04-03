using Estoque.DOMAIN.Enums;
using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.DTO.Venda
{
    public class CreateVendaDTO
    {
        public string? NumeroPedido { get; set; }
        public int ClienteId { get; set; }
        public TipoVenda TipoVenda { get; set; }
        public virtual ICollection<Item>? Itens { get; set; }
    }
}
