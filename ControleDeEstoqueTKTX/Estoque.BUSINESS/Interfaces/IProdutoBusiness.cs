using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BUSINESS.Interfaces
{
    public interface IProdutoBusiness
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetProduto(int id);
    }
}
