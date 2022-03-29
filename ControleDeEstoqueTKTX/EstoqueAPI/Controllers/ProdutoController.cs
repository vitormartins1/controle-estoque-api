using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.DTO.Produto;
using Estoque.DOMAIN.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private IProdutoBusiness produtoBusiness;

        public ProdutoController(IProdutoBusiness produtoBusiness)
        {
            this.produtoBusiness = produtoBusiness;
        }

        // GET: api/<ProdutoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<ReadProdutoDTO> produtos = produtoBusiness.GetProdutos();
                return Ok(produtos);
            }
            catch (System.Exception)
            {
                return BadRequest(ModelState);
            }
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ReadProdutoDTO produtoDTO = produtoBusiness.GetProduto(id);
            return Ok(produtoDTO);
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateProdutoDTO produtoDTO)
        {
            try
            {
                ReadProdutoDTO produtoSalvo = produtoBusiness.PostProduto(produtoDTO);
                return Ok(produtoSalvo);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProdutoDTO produto)
        {
            Result result = produtoBusiness.PutProduto(id, produto);

            if (result.IsFailed)
                return BadRequest();

            return Ok();
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Result result = produtoBusiness.DeleteProduto(id);
            if (result.IsFailed)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
