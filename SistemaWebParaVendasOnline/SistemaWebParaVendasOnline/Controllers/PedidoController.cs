using Microsoft.AspNetCore.Mvc;

namespace SistemaWebParaVendasOnline.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
