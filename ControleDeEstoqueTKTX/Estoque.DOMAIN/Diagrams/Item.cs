using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Diagrams
{
    public class Item
    {
        public int Id { get; set; }
        public string ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual TipoItem Tipo { get; set; }
    }
}
