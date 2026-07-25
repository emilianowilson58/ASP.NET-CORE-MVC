using Microsoft.AspNetCore.Mvc;

namespace SistemaWebParaVendasOnline.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
