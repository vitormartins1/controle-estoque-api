using AutoMapper;
using Estoque.DATA.DTO.Produto;
using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDTO, Produto>();
            CreateMap<Produto, ReadProdutoDTO>();
            CreateMap<UpdateProdutoDTO, Produto>();
        }
    }
}
