using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovoTerceiraApp.Models;

namespace NovoTerceiraApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            Fornecedor fornecedor = new Fornecedor()
            {
                fornecID = 1,
                nome = "Associação 171",
                endereco = "rua Falsa 157",
                tel = 24231234
            };
            ViewBag.ID = fornecedor.fornecID;
            ViewBag.nome = fornecedor.nome;
            ViewBag.endereco = fornecedor.endereco;
            ViewBag.tel = fornecedor.tel;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contato()
        {
            Pessoa pessoa = new Pessoa()
            {
                PessoaID = 1,
                Nome = "Astrogildo",
                Tipo = "Administrador"
            };

            ViewData["PessoaID"] = pessoa.PessoaID;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }
    }
}