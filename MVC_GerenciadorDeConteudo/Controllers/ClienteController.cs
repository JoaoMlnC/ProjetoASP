using Microsoft.AspNetCore.Mvc;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            return Content("Olá Mundo");
        }
    }
}
