using Estoque.DATA.Context;
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
    public class VendaRepository : IVendaRepository
    {
        private EstoqueDbContext context;

        public VendaRepository(EstoqueDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Venda> GetVendas()
        {
            IEnumerable<Venda> vendasConsultadas = context.Venda.ToList().AsEnumerable();

            if (vendasConsultadas == null)
                return null;

            context.SaveChanges();

            return vendasConsultadas;

        }

        public Venda GetVendaPorId(int id)
        {
            Venda venda = context.Venda.First(v => v.Id == id);

            if (venda == null)
                return null;

            return venda;
        }

        public Venda PostVenda(Venda venda)
        {
            context.Venda.Add(venda);
            context.SaveChanges();

            Venda vendaConsultada = context.Venda.First(v => v.Id == venda.Id);

            return vendaConsultada;
        }

        public Result PutVenda(int id, Venda venda)
        {
            context.Venda.Update(venda);

            Venda vendaAtualizada = context.Venda.First(venda => venda.Id == id);
            if (vendaAtualizada == null)
                return Result.Fail("Venda não encontrada.");

            context.SaveChanges();

            return Result.Ok();
        }

        public Result DeleteVenda(int id)
        {
            Venda vendaConsultada = context.Venda.First(v => v.Id == id);
            if (vendaConsultada == null)
                return Result.Fail("Venda não encontrada");

            context.Venda.Remove(vendaConsultada);
            context.SaveChanges();

            return Result.Ok();
        }
    }
}
