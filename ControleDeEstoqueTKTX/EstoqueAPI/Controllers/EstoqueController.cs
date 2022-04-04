using Estoque.BUSINESS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [Produces("text/json")]
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class EstoqueController : ControllerBase
    {
        private IEstoqueBusiness estoqueBusiness;

        public EstoqueController(IEstoqueBusiness estoqueBusiness)
        {
            this.estoqueBusiness = estoqueBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
