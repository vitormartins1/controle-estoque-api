using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.DTO.Produto;
using Estoque.DATA.Interfaces;
using Estoque.DOMAIN.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BUSINESS.Business
{
    public class ProdutoBusiness : IProdutoBusiness
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoBusiness(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public Result DeleteProduto(int id)
        {
            throw new NotImplementedException();
        }

        public ReadProdutoDTO GetProduto(int id)
        {
            ReadProdutoDTO produtoConsultado = produtoRepository.GetProdutoPorId(id);
            return produtoConsultado;
        }

        public IEnumerable<ReadProdutoDTO> GetProdutos()
        {
            IEnumerable<ReadProdutoDTO> produtos = produtoRepository.GetProdutos();
            return produtos;
        }

        public ReadProdutoDTO PostProduto(CreateProdutoDTO produto)
        {
            ReadProdutoDTO produtoDTO = produtoRepository.PostProduto(produto);
            return produtoDTO;
        }

        public Result PutProduto(int id, UpdateProdutoDTO produto)
        {
            Result result = produtoRepository.PutProduto(id, produto);
            return result;
        }
    }
}
