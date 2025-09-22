using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Modelo_Manha.Models;

namespace Projeto_Modelo_Manha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FAQ()
        {
            return View();
        }

        
    }
}
