using EstoqueInteligente.Infra.Interfaces.Repository;
using EstoqueInteligente.Service.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueInteligente.Api.Controllers
{
    [Route("/NCM")]
    [ApiController]
    public class NCMController : Controller
    {
        private readonly INCMRepository _NCMRepository;

        public NCMController(INCMRepository NCMRepository)
        {
            _NCMRepository = NCMRepository;
        }

        [HttpPost]
        [Route("/Arquivo")]
        public async Task<ActionResult> PostNCMArquivo(NCMArquivo arquivo)
        {
            await _NCMRepository.AtualizarNCMArquivo(arquivo);

            return Ok();
        }
      
        [HttpPut]
        public async Task<IActionResult> PutNCM(Nomenclaturas ncm)
        {

                await _NCMRepository.AlterarNCM(ncm);
                return Ok();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> PostNCM(Nomenclaturas ncm)
        {
          await  _NCMRepository.CadastrarNCM(ncm);

            return Ok();
        }
        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> DeleteNCM(string ncm)
        {
            await _NCMRepository.DeletarNCM(ncm);

            return Ok();
        }
    }
}
