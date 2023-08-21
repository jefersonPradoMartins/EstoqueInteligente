using EstoqueInteligente.Domain.Entities;
using EstoqueInteligente.Infra.Interface.Repository;
using EstoqueInteligente.Infra.Interfaces.Repository;

using EstoqueInteligente.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EstoqueInteligente.Web.Controllers
{
    
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository _enderecoRepository;
        //private readonly IProdutoRepository _produtoRepository;


        public EnderecoController(IEnderecoRepository enderecoRepository
            //, IProdutoRepository produtoRepository
            )
        {
            _enderecoRepository = enderecoRepository;
           // _produtoRepository = produtoRepository;
        }

   
        public async Task<IActionResult> Index()
        {
            ViewModels.AnimalViewData av = new ViewModels.AnimalViewData();
           

            var result = await _enderecoRepository.BuscarCidade("u");
            av.Cidades = result;

            return View(av);
        }

        public async Task<IActionResult> OnGet()
        {

            ViewModels.AnimalViewData av = new ViewModels.AnimalViewData();
           

            var result = await _enderecoRepository.BuscarCidade("u");
        av.Cidades = result;

            return View(av);
    }
    }
}
