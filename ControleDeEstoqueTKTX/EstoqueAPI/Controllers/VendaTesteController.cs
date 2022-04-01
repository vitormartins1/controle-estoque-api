using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.Context;
using Estoque.DOMAIN.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Route("api/[controller]")]
    [Produces("text/json")]
    public class VendaTesteController : ControllerBase
    {
        private EstoqueDbContext context;

        public VendaTesteController(EstoqueDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<VendaTeste> vendas = context.VendaTeste.ToList();

            if (vendas == null)
                return BadRequest(ModelState);

            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            VendaTeste v = context.VendaTeste
                .FirstOrDefault(p => p.Id == id);

            return Ok(v);
        }

        [HttpPost]
        public IActionResult Post([FromBody] VendaTeste venda)
        {
            context.VendaTeste.Add(venda);
            context.SaveChanges();

            return Ok(venda);
        }

        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] VendaTeste venda)
        //{
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    return NoContent();
        //}
    }
}
