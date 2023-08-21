using EstoqueInteligente.Models;
using EstoqueInteligente.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EstoqueInteligente.Controllers
{
    public class HomeController : Controller
    {
   

        private List<Bairro> Bairros = new List<Bairro>()
       {
           new Bairro { CodigoBairro = 1, NomeBairro = "Macaco" },
           new Bairro {CodigoBairro = 2, NomeBairro = "Baleia" }
       };
        private List<Cidade> Cidades = new List<Cidade>() {
          new  Cidade { CodigoCidade = 1,NomeCidade = "Urania" },
          new  Cidade { CodigoCidade = 2,NomeCidade = "Jales" }
        };


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //AnimalViewData animalViewData = new AnimalViewData();
            //animalViewData.Bairros = Bairros;
            //animalViewData.Cidades = Cidades;

            //return View(animalViewData);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}