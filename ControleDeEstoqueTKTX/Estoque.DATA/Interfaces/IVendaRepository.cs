using Estoque.DATA.DTO.Venda;
using Estoque.DOMAIN.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.DATA.Interfaces
{
    public interface IVendaRepository
    {
        Venda GetVendaPorId(int id);
        IEnumerable<Venda> GetVendas();
        Venda PostVenda(CreateVendaDTO venda);
        Result PutVenda(int id, UpdateVendaDTO venda);
        Result DeleteVenda(int id);
    }
}
