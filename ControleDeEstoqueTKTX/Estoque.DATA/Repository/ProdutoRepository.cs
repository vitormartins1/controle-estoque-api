using AutoMapper;
using Estoque.DATA.Context;
using Estoque.DATA.DTO.Produto;
using Estoque.DATA.Interfaces;
using Estoque.DOMAIN.Models;
using FluentResults;
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
        private IMapper mapper;

        public ProdutoRepository(EstoqueDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Result DeleteProduto(int id)
        {
            Produto produto = context.Produto.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                return Result.Fail("Produto não encontrado.");

            context.Remove(produto);
            context.SaveChanges();

            return Result.Ok();
        }

        public ReadProdutoDTO GetProdutoPorId(int id)
        {
            Produto produtoConsultado = context.Produto
                .FirstOrDefault(p => p.Id == id);

            if (produtoConsultado == null) return null;

            return mapper.Map<ReadProdutoDTO>(produtoConsultado);
        }

        public IEnumerable<ReadProdutoDTO> GetProdutos()
        {
            IEnumerable<Produto> produtosConsultados = context.Produto.ToList().AsEnumerable();
            if (produtosConsultados == null) return null;

            return mapper.Map<IEnumerable<ReadProdutoDTO>>(produtosConsultados);
        }

        public ReadProdutoDTO PostProduto(CreateProdutoDTO produtoDTO)
        {
            Produto produto = mapper.Map<Produto>(produtoDTO);

            context.Produto.Add(produto);
            context.SaveChanges();

            return mapper.Map<ReadProdutoDTO>(produto);
        }

        public Result PutProduto(int id, UpdateProdutoDTO produtoDTO)
        {
            Produto produto = context.Produto.First(p => p.Id == id);

            if (produto == null) 
                return Result.Fail("Produto não encontrado.");

            mapper.Map(produtoDTO, produto);
            context.SaveChanges();

            return Result.Ok();
        }
    }
}
