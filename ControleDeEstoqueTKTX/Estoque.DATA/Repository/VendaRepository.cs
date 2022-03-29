using AutoMapper;
using Estoque.DATA.Context;
using Estoque.DATA.DTO.Venda;
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
        private IMapper mapper;

        public VendaRepository(EstoqueDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
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

        public Venda PostVenda(CreateVendaDTO vendaDTO)
        {
            Venda venda = mapper.Map<Venda>(vendaDTO);

            context.Venda.Add(venda);
            context.SaveChanges();

            return venda;
        }

        public Result PutVenda(int id, UpdateVendaDTO venda)
        {
            Venda vendaAtualizada = context.Venda.First(v => v.Id == id);
            if (vendaAtualizada == null)
                return Result.Fail("Venda não encontrada.");

            //context.Venda.Update(venda);
            mapper.Map(venda, vendaAtualizada);
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
