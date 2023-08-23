using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueInteligente.Api.Controllers
{
    [Route("/ProdutoFormula")]
    [ApiController]
  
    public class ProdutoFormulaController : Controller
    {
        private  IProdutoFormulaRepository _produtoFormulaRepository;

        public ProdutoFormulaController(IProdutoFormulaRepository produtoFormulaRepository)
        {
            _produtoFormulaRepository = produtoFormulaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostProdutoFormula(ProdutoFormulaDto produtoFormulaDto)
        {
          await  _produtoFormulaRepository.CadastrarFormula(produtoFormulaDto);

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProdutoFormula(int CodigoFormula)
        {
            await _produtoFormulaRepository.DeletarFormula(CodigoFormula);
            return Ok();
        }
    }
}
