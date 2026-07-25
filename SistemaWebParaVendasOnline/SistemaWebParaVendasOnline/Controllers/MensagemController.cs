using Microsoft.AspNetCore.Mvc;

namespace SistemaWebParaVendasOnline.Controllers
{
    public class MensagemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
