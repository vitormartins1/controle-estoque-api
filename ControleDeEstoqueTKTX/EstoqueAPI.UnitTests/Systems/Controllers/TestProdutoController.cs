using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.DTO.Produto;
using EstoqueAPI.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace EstoqueAPI.UnitTests.Systems.Controllers
{
    public class TestProdutoController
    {
        [Fact]
        public void Get_OnSucess_ReturnsStatusCode200()
        {
            // Arrange
            var mockBusiness = new Mock<IProdutoBusiness>();

            List<ReadProdutoDTO> produtos = new List<ReadProdutoDTO>();
            produtos.Add(new ReadProdutoDTO());
            mockBusiness
                .Setup(service => service.GetProdutos())
                .Returns(produtos);

            var produtoController = new ProdutoController(mockBusiness.Object);

            // Act
            var result = (OkObjectResult)produtoController.Get();

            // Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public void Get_OnNull_ReturnsStatusCode400()
        {
            // Arrange
            var mockBusiness = new Mock<IProdutoBusiness>();

            List<ReadProdutoDTO> produtos = null;
            mockBusiness
                .Setup(service => service.GetProdutos())
                .Returns(produtos);

            var produtoController = new ProdutoController(mockBusiness.Object);

            // Act
            var result = (BadRequestObjectResult)produtoController.Get();

            // Assert
            result.StatusCode.Should().Be(400);
        }

        [Fact]
        public void Get_OnEmpty_ReturnsStatusCode204()
        {
            // Arrange
            var mockBusiness = new Mock<IProdutoBusiness>();

            List<ReadProdutoDTO> produtos = new List<ReadProdutoDTO>();
            mockBusiness
                .Setup(service => service.GetProdutos())
                .Returns(produtos);

            var produtoController = new ProdutoController(mockBusiness.Object);

            // Act
            var result = (StatusCodeResult)produtoController.Get();

            // Assert
            result.StatusCode.Should().Be(204);
        }
    }
}