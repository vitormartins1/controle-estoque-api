using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task<Produto> GetProdutoAsync(int id);
    }
}
