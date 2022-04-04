using Estoque.BUSINESS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [Produces("text/json")]
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ItemController : ControllerBase
    {
        private IItemBusiness itemBusiness;

        public ItemController(IItemBusiness itemBusiness)
        {
            this.itemBusiness = itemBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
