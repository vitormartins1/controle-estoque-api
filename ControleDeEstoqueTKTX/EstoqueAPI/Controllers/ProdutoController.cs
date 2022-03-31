using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.DTO.Produto;
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
    public class ProdutoController : ControllerBase
    {
        private IProdutoBusiness produtoBusiness;

        public ProdutoController(IProdutoBusiness produtoBusiness)
        {
            this.produtoBusiness = produtoBusiness;
        }
        
        #region [Swagger]
        [SwaggerResponse(200, "Sucesso. Retorna o enumerado de Produtos cadastrados.", typeof(List<ReadProdutoDTO>))]
        [SwaggerResponse(204, "Consulta feita com sucesso porém nenhum Produto foi encontrado.")]
        [SwaggerResponse(404, "O recurso não foi localizado e retornou um valor nulo.")]
        [SwaggerOperation(
            Summary = "Recupera todos os produtos cadastrados.",
            Description = "Requer privilégios de acesso. Retorna um enumerado contendo todos os Produtos cadastrados."
        )]
        #endregion
        [HttpGet(Name = "GetProdutos")]
        public IActionResult Get()
        {
            IEnumerable<ReadProdutoDTO> produtos = produtoBusiness.GetProdutos();

            if (produtos == null)
                return BadRequest(ModelState);
            else if (!produtos.Any())
                return NoContent();

            return Ok(produtos);
        }

        #region [Swagger]
        [SwaggerResponse(200, "Sucesso. Retorna o Produto relativo ao id fornecido.", typeof(IEnumerable<ReadProdutoDTO>))]
        [SwaggerResponse(204, "Caso o produto não seja encontrado no banco de dados.")]
        [SwaggerOperation(
            Summary = "Recupera um produto cadastrado.",
            Description = "Requer privilégios de acesso. Retorna um Produto cadastrado passando seu Id como parâmetro."
        )]
        #endregion
        [HttpGet("{id}", Name = "GetProdutoPorId")]
        public IActionResult Get(int id)
        {
            ReadProdutoDTO produto = produtoBusiness.GetProduto(id);

            if (produto == null)
                return NoContent();

            return Ok(produto);
        }
        
        #region [Swagger]
        [SwaggerResponse(200, "O Produto foi criado com sucesso.", typeof(ReadProdutoDTO))]
        [SwaggerResponse(400, "Os dados do Produto são inválidos.")]
        [SwaggerOperation(
            Summary = "Cadastra um novo Produto.",
            Description = "Requer privilégios de administrador para cadastrar novos Produtos. \n Retorna o Produto cadastrado."
        )]
        #endregion
        [HttpPost]
        public IActionResult Post(
            [FromBody, SwaggerRequestBody("O Produto a ser criado.", Required = true)] CreateProdutoDTO produtoDTO)
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

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProdutoDTO produto)
        {
            Result result = produtoBusiness.PutProduto(id, produto);

            if (result.IsFailed)
                return BadRequest();

            return Ok();
        }

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
