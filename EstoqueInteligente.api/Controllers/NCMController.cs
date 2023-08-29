using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using EstoqueInteligente.Service.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static EstoqueInteligente.Api.Controllers.NCMController;

namespace EstoqueInteligente.Api.Controllers
{
    [Route("/NCM")]
    [ApiController]
    public class NCMController : Controller
    {
        private readonly INCMService _ncmService;

        public NCMController(INCMService ncmService)
        {
            _ncmService = ncmService;
        }

        [HttpPost]
        [Route("/Arquivo")]
        public async Task<ActionResult> PostNCMArquivo(NCMArquivo arquivo)
        {
            await _ncmService.UpdateAsync(arquivo);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutNCM(Nomenclaturas ncm)
        {
            await _ncmService.UpdateAsync(ncm);
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> PostNCM(Nomenclaturas ncm)
        {
            await _ncmService.CreateAsync(ncm);

            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> DeleteNCM(string ncm)
        {
            await _ncmService.RemoveAsync(ncm);

            return Ok();
        }
        [HttpGet]
        [Route("/Lists")]
        public async Task<IActionResult> GetList()
        {
            return Ok( await _ncmService.GetAllAsync());
        }
        [HttpGet]
        [Route("/GetById")]
        public async Task<ActionResult> GetById(string codigo)
        {
            var result = await _ncmService.GetByIdAsync(codigo);
            if(result == null)
            {
                return NotFound("NCM não encontrado");
            }
            return Ok(result) ;
        }

       


    }
}
