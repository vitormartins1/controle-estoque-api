using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.DTO.Venda;
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
        [SwaggerResponse(201, "", typeof(ReadVendaDTO))]
        [SwaggerResponse(400, "")]
        [SwaggerOperation(
            Summary = "Cadastra uma nova Venda.",
            Description = "Requer privilégios de administrador para cadastrar novas Vendas. \n Retorna a Venda cadastrado.",
            OperationId = "CriaVenda",
            Tags = new[] { "Venda" }
        )]
        public IActionResult Post([FromBody] CreateVendaDTO venda)
        {
            Venda vendaSalva = vendaBusiness.PostVenda(venda);
            if (vendaSalva == null)
                return BadRequest(ModelState);
            return Ok(vendaSalva);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateVendaDTO venda)
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
