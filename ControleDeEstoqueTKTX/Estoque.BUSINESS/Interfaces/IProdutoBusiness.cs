using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.DATA.DTO.Produto;
using FluentResults;

namespace Estoque.BUSINESS.Interfaces
{
    public interface IProdutoBusiness
    {
        List<ReadProdutoDTO> GetProdutos();
        ReadProdutoDTO GetProduto(int id);
        ReadProdutoDTO PostProduto(CreateProdutoDTO produto);
        Result PutProduto(int id, UpdateProdutoDTO produto);
        Result DeleteProduto(int id);
    }
}
