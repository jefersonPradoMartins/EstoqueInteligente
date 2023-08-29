using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueInteligente.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FormulaController : Controller
    {
        private IFormulaService _formulaService;
        public FormulaController(IFormulaService formulaService)
        {
            _formulaService = formulaService;
        }
        [HttpGet("List")]
        
        public async Task<List<FormulaOnlyDto>> GetAll()
        {
            return await _formulaService.GetAll();
        }
        [HttpPost("Create")]
        public async Task<IActionResult> PostFormula(FormulaDto formulaDto)
        {
            await _formulaService.CreateFormula(formulaDto);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFormula(int codigoFormula)
        {
            await _formulaService.RemoveFormula(codigoFormula);
            return Ok();
        }
    }
}
