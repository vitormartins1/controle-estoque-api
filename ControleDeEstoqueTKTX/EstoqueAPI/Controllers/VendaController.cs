using Estoque.BUSINESS.Interfaces;
using Estoque.DOMAIN.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {
        private IVendaBusiness vendaBusiness;

        public VendaController(IVendaBusiness vendaBusiness)
        {
            this.vendaBusiness = vendaBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Venda> vendas = vendaBusiness.GetVendas();

            if (vendas == null)
                return BadRequest(ModelState);

            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Venda venda = vendaBusiness.GetVendaPorId(id);
            if (venda == null)
                return BadRequest(ModelState);

            return Ok(venda);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Venda venda)
        {
            Venda vendaSalva = vendaBusiness.PostVenda(venda);
            if (vendaSalva == null)
                return BadRequest(ModelState);
            return Ok(vendaSalva);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Venda venda)
        {
            Result result = vendaBusiness.PutVenda(id, venda);

            if (result.IsFailed)
                return NotFound(result.Errors.ToString());

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Result result = vendaBusiness.DeleteVenda(id);

            if (result.IsFailed)
                return NotFound();

            return NoContent();
        }
    }
}
