using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DOMAIN.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int Entradas { get; set; } // ItemEstoque, ItemRetornado
        public int Saidas { get; set; } // ItemVenda, ItemDanificado, ItemConsignado
        public int QuantidadeAtual { get; set; } // Diferença entre Entradas e Saidas
        public virtual ICollection<Produto> Produtos { get; set; }
        public int ProdutoId { get; set; }
        public int ProdutoNome { get; set; }
    }
}
