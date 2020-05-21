using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuintaApp.Models;

namespace QuintaApp.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            Funcionario func = new Funcionario() 
            {
                FuncId = 1,
                FuncNome = "Bronquinho",
                FuncFuncao = "Fulião"
            };
            return View(func);
        }


        [HttpPost]
        public ActionResult Listar(Funcionario funcionario)
        {
            return View(funcionario);
        }

        //[HttpPost]
        //public ActionResult Listar(Funcionario funcionario)
        //{
        //    ViewData["FuncId"] = funcionario.FuncId;
        //    ViewData["FuncNome"] = funcionario.FuncNome;
        //    ViewData["FuncFuncao"] = funcionario.FuncFuncao;
        //    return View();
        //}

        /// Além do método FormCollection pode utilizar objetos como parametros.
        /// Exemplo acima
        //[HttpPost]
        //public ActionResult Listar(FormCollection form)
        //{
        //    ViewData["FuncId"] = form["FuncId"];
        //    ViewData["FuncNome"] = form["FuncNome"];
        //    ViewData["FuncFuncao"] = form["FuncFuncao"];
        //    return View();
        //}

        /// Atraves do metodo post é passado os parametros individuáis
        /// para substituir esta forma, utilizasse uma coleção de dados vindo do formulário
        /// FormeCollection form
        //[HttpPost]
        //public ActionResult Listar(ushort FuncId, string FuncNome, string FuncFuncao)
        //{
        //    ViewData["FuncId"] = FuncId;
        //    ViewData["FuncNome"] = FuncNome;
        //    ViewData["FuncFuncao"] = FuncFuncao;
        //    return View();
        //}
    }
}