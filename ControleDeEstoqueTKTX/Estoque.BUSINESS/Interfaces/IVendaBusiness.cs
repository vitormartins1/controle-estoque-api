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
        Venda PostVenda(Venda venda);
        Result PutVenda(int id, Venda venda);
        Result DeleteVenda(int id);
    }
}
