using Microsoft.AspNetCore.Mvc;
using SistemaWebParaVendasOnline.Data;
using SistemaWebParaVendasOnline.Models;
using SistemaWebParaVendasOnline.Servico.LoginService;
using SistemaWebParaVendasOnline.ViewModel;

namespace SistemaWebParaVendasOnline.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountInterface _AccountInterface;

        public AccountController(AccountInterface AccountInterface)
        {
            _AccountInterface = AccountInterface;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(RegistroViewModel registroViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registroViewModel);
            }
        
            var usuario = await _AccountInterface.CadastroUsuario(registroViewModel);

            return RedirectToAction("Login");
        }
    }
}
