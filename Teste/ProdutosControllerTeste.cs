using Api.Controllers;
using Microsoft.EntityFrameworkCore;
using Moq;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Teste
{
    public class ProdutosControllerTeste
    {
        private readonly Mock<DbSet<Produtos>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Produtos _produtos;
        
        public ProdutosControllerTeste()
        {
        _mockSet = new Mock<DbSet<Produtos>>();
        _mockContext = new Mock<Context>();
        _produtos = new Produtos { Id = 1, Nome = "Teste Produtos" };

        _mockContext.Setup(expression: m => m.Produto).Returns(_mockSet.Object);

        _mockContext.Setup(expression: m => m.Produto.FindAsync(params keyValues: 1))
            .ReturnAsync(_produtos);

        _mockContext.Setup(expression: m => m.SaveChangesAsync(cancellationToken: It.IsAny<CancellationToken>()))
                    .ReturnsAsync(1);        
        }

        [Fact]
        public async Task Get_Produtos()
        {
            var service = new ProdutosController(_mockContext.Object);

            var testProduto = await service.GetProdutos(id: 1);

            _mockSet.Verify(expression:m => m.FindAsync(params keyValues: 1),
                Times.Once());
        }

        [Fact]
        public async Task Put_Produtos()
        {
            var service = new ProdutosController(_mockContext.Object);

            var testProduto = await service.PutProdutos(id: 1,_produtos);

            _mockContext.Verify(expression: m => m.SaveChangesAsync(cancellationToken:It.IsAny<CancellationToken>()),
                Times.Once());
        }

        [Fact]
        public async Task Post_Produtos()
        {
            var service = new ProdutosController(_mockContext.Object);

            var testProduto = await service.PostProdutos( _produtos);

            _mockSet.Verify(expression: x => x.Add(_produtos), Times.Once);
            _mockContext.Verify(expression: m => m.SaveChangesAsync(cancellationToken: It.IsAny<CancellationToken>()),
                Times.Once());
        }

        [Fact]
        public async Task Delete_Produtos()
        {
            var service = new ProdutosController(_mockContext.Object);
            var testProduto = await service.DeleteProdutos(id:1);
            _mockSet.Verify(expression: m => m.FindAsync(params keyValues: 1),
                Times.Once());
            _mockSet.Verify(expression: x => x.Remove(_produtos), Times.Once);
            _mockContext.Verify(expression: m => m.SaveChangesAsync(cancellationToken: It.IsAny<CancellationToken>()),
                Times.Once());
        }
    }
}
