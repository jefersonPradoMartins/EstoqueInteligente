using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EstoqueInteligente.Api.Controllers
{
    [Route("/Formula")]
    [ApiController]

    public class FormulaController : Controller
    {
        private IFormulaService _formulaService;

        public FormulaController(IFormulaService formulaService)
        {
            _formulaService = formulaService;
        }

        [HttpGet]
        [Route("/List")]
        public async Task<List<FormulaOnlyDto>> GetAll()
        {
            return await _formulaService.GetAll();
           
        }

        [HttpPost]
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
