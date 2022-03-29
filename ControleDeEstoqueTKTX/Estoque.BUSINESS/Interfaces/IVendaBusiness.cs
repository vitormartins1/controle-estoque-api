using Estoque.DATA.DTO.Venda;
using Estoque.DOMAIN.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.BUSINESS.Interfaces
{
    public interface IVendaBusiness
    {
        public IEnumerable<Venda> GetVendas();
        Venda GetVendaPorId(int id);
        Venda PostVenda(CreateVendaDTO venda);
        Result PutVenda(int id, UpdateVendaDTO venda);
        Result DeleteVenda(int id);
    }
}
