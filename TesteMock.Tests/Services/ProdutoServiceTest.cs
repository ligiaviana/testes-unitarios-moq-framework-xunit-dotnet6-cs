using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMock.Models.Entities;
using TesteMock.Repository.Interfaces;
using TesteMock.Services;
using TesteMock.Services.Interfaces;

namespace TesteMock.Tests.Services
{
    public class ProdutoServiceTest
    {
        private readonly IProdutoService service;
        private readonly Mock<IProdutoRepository> repository;

        public ProdutoServiceTest()
        {
            repository= new Mock<IProdutoRepository>();
            service = new ProdutoService(
                repository.Object
                );
        }

        [Fact(DisplayName = "AddProduto: 01 - Deve utilizar repository.AddProduto")]
        public void AddProduto_01()
        {
            int id = 1;
            string nome = "PRODUTO 01";
            string codigo = "1234";

            service.AddProduto(id, nome, codigo);

            repository.Verify(p => p.AddProduto(id, nome, codigo), Times.Once);
        }

        [Fact(DisplayName = "AddProduto: 02 - Deve retornar o valor recebido de repository.AddProduto")]
        public void AddProduto_02()
        {
            int id = 1;
            string nome = "PRODUTO 01";
            string codigo = "1234";

            Produto produtoEsperado = new Produto
            {
                ProdutoId = id,
                Nome = nome,
                Codigo = codigo
            };

            repository
                .Setup(p => p.AddProduto(id, nome, codigo))
                .Returns( produtoEsperado );

            Produto produtoRetornado = service.AddProduto(id, nome, codigo);

            Assert.Same(produtoEsperado, produtoRetornado);
        }
    }
}
