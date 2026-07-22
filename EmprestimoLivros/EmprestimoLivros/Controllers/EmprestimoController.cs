using EmprestimoLivros.Date;
using EmprestimoLivros.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoController : Controller
    {

        readonly private ApplicationDbContext _db; //navegando e manipulando o banco
        public EmprestimoController(ApplicationDbContext db) //para se conectar ao banco
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos; //buscando todos os campos da tabela e enviando em forma de lista

            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimosModel? emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if(emprestimo == null)
            {
                return NotFound();
            }
            return View(emprestimo);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimosModel? emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);
           
            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        [HttpGet]
        public IActionResult Cadastrar() 
        {
            return View();
        }

        //------------------------------------------------------------------------------

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Cadastro Realizado com sucesso";
                return RedirectToAction("Index"); //Redirecionar para outra view
            }

            return View(); //vai permanecer na view quando os dados não forem preenchido
        }


        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimo);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Edição Realizado com sucesso";
                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "algum erro ocorreu durante a Edição";

            return View(emprestimo);

        }

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
            if(emprestimo == null)
            {
                return NotFound();
            }

            _db.Emprestimos.Remove(emprestimo);
            _db.SaveChanges();
            TempData["MensagemSucesso"] = "Remoção Realizado com sucesso";
            return RedirectToAction("Index");
        }
    }
}
