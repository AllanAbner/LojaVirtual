using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato() => View();

        public IActionResult Cadastro() => View();

        public IActionResult Login() => View();

        public IActionResult Carrinho() => View();
    }
}