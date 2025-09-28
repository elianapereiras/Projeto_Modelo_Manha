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
        public IActionResult Solicitar()
        {
            var usuarioLogado = HttpContext.Session.GetString("UserEmail");

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Solicitar(string solicitante, string local)
        {
            //quando o banco existir tratar os dados
            ViewBag.Msg = "Solicitação registrada com sucesso";
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost] //salvar
        public IActionResult Login(string email, string senha)
        {
            if (email == "eu@gmail.com" && senha == "123")
            {
                HttpContext.Session.SetString("UserEmail", email);
                return RedirectToAction("Solicitar", "Home");
            }

            ViewBag.Mesage = "Login inválido!";
            return View();

        }
        [HttpGet]
        public ActionResult CadLogin()
        {
            return View();
        }
    }
}
