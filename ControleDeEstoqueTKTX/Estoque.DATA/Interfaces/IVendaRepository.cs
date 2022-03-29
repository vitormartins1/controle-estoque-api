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
        Venda PostVenda(Venda venda);
        Result PutVenda(int id, Venda venda);
        Result DeleteVenda(int id);
    }
}
