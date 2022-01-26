using Estoque.BUSINESS.Interfaces;
using Estoque.DOMAIN.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        // GET: api/<ProdutoController>
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IProdutoBusiness produtoBusiness)
        {
            try
            {
                var produtos = await produtoBusiness.GetProdutos();
                return Ok(produtos);
            }
            catch (System.Exception)
            {
                return BadRequest(ModelState);
            }
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id,
            [FromServices] IProdutoBusiness produtoBusiness)
        {
            var produto = await produtoBusiness.GetProduto(id);
            return Ok(produto);
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
