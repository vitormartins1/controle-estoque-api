using Estoque.DATA.Context;
using Estoque.DATA.Interfaces;
using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private EstoqueDbContext context;

        public ProdutoRepository(EstoqueDbContext context)
        {
            this.context = context;
        }

        public async Task<Produto> GetProdutoAsync(int id)
        {
            var produtoConsultado = context.Produto
                .Where(p => p.Id == id)
                .FirstOrDefault();

            if (produtoConsultado == null) return null;
            await context.SaveChangesAsync();
            return produtoConsultado;
        }

        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            var produtosConsultados = context.Produto.ToList().AsEnumerable();
            if (produtosConsultados == null) return null;
            await context.SaveChangesAsync();
            return produtosConsultados.AsEnumerable();
        }
    }
}
