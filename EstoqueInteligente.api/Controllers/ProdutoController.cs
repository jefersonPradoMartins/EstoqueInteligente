using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueInteligente.Api.Controllers
{
    [Route("/Produto")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        //[HttpPost]
        //public async Task<ActionResult> PostProduto(ProdutoDto produtoDto)
        //{
        //    await _produtoRepository.CadastrarProduto(produtoDto);

        //    return Ok();
        //}

    }
}

