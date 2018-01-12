using Microsoft.AspNetCore.Mvc;
using projetoCidades.Models;
using projetoCidades.Repositorio;

namespace projetoCidades.Controllers {
    public class CidadesController : Controller {
        CidadeRep cidadeRep = new CidadeRep ();
        Cidade cidade = new Cidade ();
        public IActionResult Index () {
            // Execução do método LISTARCIDADES, para trazer a lista de cidades.
            var list = cidadeRep.Listar ();
            return View (list);
        }
        public IActionResult CidadesEstados () {
            var list = cidadeRep.Listar ();
            return View (list);
        }
        public IActionResult TodosOsDados () {
            var list = cidadeRep.Listar ();
            return View (list);
        }
        public IActionResult Cadastrar () {
            return View ();
        }

        // [HttpPost] é usado para receber os parametrôs de um formulário.
        // [Bind] é usado quando recebemos as informações de um formulário.
        [HttpPost]
        public IActionResult Cadastrar ([Bind] Cidade cidade) {
            cidadeRep.Cadastrar (cidade);
            return RedirectToAction("Index");
        }
    }
}