using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Service.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueInteligente.Api.Controllers
{
  
    [ApiController]
    [Route("api/grupo/[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;

        public GrupoController(IGrupoService grupoService)
        {
            this._grupoService = grupoService;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await _grupoService.GetAll());
        }

        [HttpGet]
        [Route("/getById")]
        public async Task<IActionResult> GetById(int codigoGrupo)
        {
            return Ok( await _grupoService.GetById(codigoGrupo));
        }

        [HttpGet]
        [Route("/getByName")]
        public async Task<IActionResult> GetByName(string nomeGrupo)
        {
            return Ok(await _grupoService.GetByName(nomeGrupo));
        }

        [HttpDelete]
        [Route("/delete")]
        public async Task<IActionResult> DeleteGrupo(int codigoGrupo)
        {
            await _grupoService.DeleteGrupoAsyc(codigoGrupo);
            return Ok();
        }
        [HttpPost]
        [Route("/create")]
        public async Task<IActionResult> CreateGrupo(Grupo grupo)
        {
           await _grupoService.CreateGrupoAsyc(grupo);
            return Ok();
        }
        [HttpPut]
        [Route("/update")]
        public async Task<IActionResult> UpdateGrupo(Grupo grupo)
        {
            await _grupoService.UpdateGrupoAsyc(grupo);
            return Ok();
        }
    }
}
