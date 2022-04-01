using Estoque.BUSINESS.Interfaces;
using Estoque.DATA.DTO.Produto;
using EstoqueAPI.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
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

            var produtos = new List<ReadProdutoDTO>();
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

            var produtos = new List<ReadProdutoDTO>();
            produtos = null;

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

            var produtos = new List<ReadProdutoDTO>();
            mockBusiness
                .Setup(service => service.GetProdutos())
                .Returns(produtos);

            var produtoController = new ProdutoController(mockBusiness.Object);

            // Act
            var result = (StatusCodeResult)produtoController.Get();

            // Assert
            result.StatusCode.Should().Be(204);
        }

        [Fact]
        public void GetProdutoPorId_OnSucess_ReturnsStatusCode200()
        {
            // Arrange
            var mockBusiness = new Mock<IProdutoBusiness>();

            var produto = new ReadProdutoDTO()
            {
                Id = 1,
                NomeProduto = "Produto Teste",
                DescricaoProduto = "Produto criado para testar resposta 200.",
                ValorProduto = 23
            };
            
            mockBusiness
                .Setup(service => service.GetProduto(1))
                .Returns(produto);

            var produtoController = new ProdutoController(mockBusiness.Object);

            // Act
            var result = (OkObjectResult)produtoController.Get(1);

            // Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public void GetProdutoPorId_OnNull_ReturnsStatusCode204()
        {
            // Arrange
            var mockBusiness = new Mock<IProdutoBusiness>();

            int id = It.IsAny<int>();

            //mockBusiness
            //    .Setup(service => service.GetProduto(id))
            //.Returns(It.IsAny<ReadProdutoDTO>());

            var sut = new ProdutoController(mockBusiness.Object);
            //sut.BadRequest();

            // Act
            var result = (NoContentResult)sut.Get(id);

            // Assert
            result.StatusCode.Should().Be(204);
        }

        [Fact]
        public void GetProdutoPorId_OnNull_ReturnsStatusCode400()
        {
            // Arrange
            
            int id = It.IsAny<int>();
            var mockBusiness = new Mock<IProdutoBusiness>();

            var produto = new ReadProdutoDTO
            {
                NomeProduto = null,
                DescricaoProduto = null
            };

            mockBusiness
                .Setup(m => m.GetProduto(id))
                .Returns(produto);

            var sut = new ProdutoController(mockBusiness.Object);
            Action act = () => sut.Get(id);
            sut.BadRequest();


            // Act
            var result = (NotFoundObjectResult)sut.Get(-10);

            // Assert
            result.StatusCode.Should().Be(400);
        }

        public void GetProdutoPorId_OnNull_ReturnsStatusCode404()
        {
            // Arrange
            var mockBusiness = new Mock<IProdutoBusiness>();

            int id = It.IsAny<int>();

            var sut = new ProdutoController(mockBusiness.Object);
            sut.BadRequest();

            // Act
            var result = sut.NotFound();

            // Assert
            result.StatusCode.Should().Be(404);
        }
    }
}