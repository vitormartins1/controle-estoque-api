using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.DTO.Produto
{
    public class UpdateProdutoDTO
    {
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public string DescricaoProduto { get; set; }
    }
}
