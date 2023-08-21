using EstoqueInteligente.Domain.Entities;
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
        public async Task<IActionResult> PutNCM(NCM ncm)
        {
            try
            {
                await _NCMRepository.AlterarNCM(ncm);
                return Ok();
            }
            catch (Exception ex)
            {
              return BadRequest();
            }
         

           
        }

        [HttpPost]
        [Route("/PostNCM")]
        public async Task<ActionResult> PostNCM(NCM ncm)
        {
           

            return Ok();
        }


    }

}
