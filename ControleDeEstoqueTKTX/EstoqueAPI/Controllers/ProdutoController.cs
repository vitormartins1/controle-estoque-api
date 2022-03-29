using Estoque.BUSINESS.Interfaces;
using Estoque.DOMAIN.Models;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Post([FromBody] Produto produto, [FromServices] IProdutoBusiness produtoBusiness)
        {
            try
            {
                var produtoSalvo = await produtoBusiness.PostProduto(produto);
                return Ok(produtoSalvo);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Produto produto, [FromServices] IProdutoBusiness produtoBusiness)
        {
            try
            {
                var produtoAtualizado = await produtoBusiness.PutProduto(id, produto);
                return Ok(produtoAtualizado);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, [FromServices] IProdutoBusiness produtoBusiness)
        {
            var produtoExcluido = await produtoBusiness.DeleteProduto(id);
            if (produtoExcluido == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
