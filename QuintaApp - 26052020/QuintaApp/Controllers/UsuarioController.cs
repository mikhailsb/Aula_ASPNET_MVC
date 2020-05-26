using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuintaApp.Models;

namespace QuintaApp.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            //if (string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            //}

            if (usuario.Senha != usuario.ConfirmaSenha)
            {
                ModelState.AddModelError("Senha", "Senhas não combinam.");
            }

            if(ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult ValidaLogin(string Login)
        {
            var dbExemplo = new Collection<string>
            {
                "Catraio",
                "fedelho",
                "Infante"
            };

            return Json(dbExemplo.All(a => a.ToUpper() != Login.ToUpper()),JsonRequestBehavior.AllowGet);
        }
    }
}