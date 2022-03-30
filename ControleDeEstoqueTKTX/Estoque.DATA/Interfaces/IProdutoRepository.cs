using Estoque.DATA.DTO.Produto;
using Estoque.DOMAIN.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<ReadProdutoDTO> GetProdutos();
        ReadProdutoDTO GetProdutoPorId(int id);
        ReadProdutoDTO PostProduto(CreateProdutoDTO produtoDTO);
        Result PutProduto(int id, UpdateProdutoDTO produto);
        Result DeleteProduto(int id);
    }
}
