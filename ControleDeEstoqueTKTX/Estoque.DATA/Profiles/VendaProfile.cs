using AutoMapper;
using Estoque.DATA.DTO.Venda;
using Estoque.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Profiles
{
    public class VendaProfile : Profile
    {
        public VendaProfile()
        {
            CreateMap<CreateVendaDTO, Venda>();
            CreateMap<Venda, ReadVendaDTO>();
            CreateMap<UpdateVendaDTO, Venda>();
        }
    }
}
