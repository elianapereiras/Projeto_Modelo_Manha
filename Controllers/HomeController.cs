using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Modelo_Manha.Models;

namespace Projeto_Modelo_Manha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Dados_DbContext  _context;

        public HomeController(ILogger<HomeController> logger, Dados_DbContext context)
        {
            _logger = logger;
            _context = context;
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
        [HttpGet]
        public IActionResult Solicitar()
        {
            var usuarioLogado = HttpContext.Session.GetString("UserEmail");

            if (string.IsNullOrEmpty(usuarioLogado))
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        
        [HttpPost] //efetuar o processo de login, se os dados digitados no form existirem na tabela login
        public IActionResult Login(Login login)
        {
           
            return View();// volta para a View do login

        }

        [HttpGet]//carregar(abrir) a view Cadlogin
        public ActionResult CadLogin()
        {
            return View();
        }

        [HttpPost]//Fazer o cadastro dos dados referente ao login
        public ActionResult CadLogin(Login login)
        {
            if (ModelState.IsValid)
            {
                _context.login.Add(login);
                _context.SaveChanges();
                ViewBag.msg = "Dados Cadastrados com sucesso!";
                return RedirectToAction("Index", "home");
            }
            return View();// se não foi digitado nada no form login retorna para a view login
        }
    }
}
