using Microsoft.AspNetCore.Mvc;

namespace SistemaWebParaVendasOnline.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
