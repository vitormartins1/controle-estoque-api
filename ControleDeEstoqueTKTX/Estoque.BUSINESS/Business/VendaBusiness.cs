using Estoque.BUSINESS.Interfaces;
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
    public class VendaBusiness : IVendaBusiness
    {
        private IVendaRepository vendaRepository;

        public VendaBusiness(IVendaRepository vendaRepository)
        {
            this.vendaRepository = vendaRepository;
        }

        public Result DeleteVenda(int id)
        {
            Result result = vendaRepository.DeleteVenda(id);
            return result;
        }

        public Venda GetVendaPorId(int id)
        {
            Venda venda = vendaRepository.GetVendaPorId(id);
            return venda;
        }

        public IEnumerable<Venda> GetVendas()
        {
            IEnumerable<Venda> vendas = vendaRepository.GetVendas();
            return vendas;
        }

        public Venda PostVenda(Venda venda)
        {
            Venda vendaConsultada = vendaRepository.PostVenda(venda);
            return vendaConsultada;
        }

        public Result PutVenda(int id, Venda venda)
        {
            Result result = vendaRepository.PutVenda(id, venda);
            return result;
        }
    }
}
