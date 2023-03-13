using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteMock.Models.Entities;
using TesteMock.Services.Interfaces;

namespace TesteMock.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public Produto AddProduto(int id, string nome, string codigo)
        {
            return _service.AddProduto(id, nome, codigo);
        }
    }
}
