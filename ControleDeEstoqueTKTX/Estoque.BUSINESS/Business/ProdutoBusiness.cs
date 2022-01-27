using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.Interfaces;
using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BUSINESS.Business
{
    public class ProdutoBusiness : IProdutoBusiness
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoBusiness(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task<Produto> DeleteProduto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> GetProduto(int id)
        {
            var produtoConsultado = await _produtoRepository.GetProdutoAsync(id);
            return produtoConsultado;
        }

        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            var produtos = await _produtoRepository.GetProdutosAsync();
            return produtos;
        }

        public Task<Produto> PostProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> PutProduto(int id, Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
