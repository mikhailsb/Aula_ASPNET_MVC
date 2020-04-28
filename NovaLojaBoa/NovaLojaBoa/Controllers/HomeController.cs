using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NovaLojaBoa.Models;

namespace NovaLojaBoa.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente()
            {
                CliID = 23,
                CliNome = "Gizcreuza",
                CliNasc = DateTime.Parse("23/05/1996"),
                CliEnd = "Rua Tá Difícil, 00"
            };

            ViewData["CliId"] = cliente.CliID;
            ViewData["CliNome"] = cliente.CliNome;
            ViewData["CliNasc"] = cliente.CliNasc;
            ViewData["CliEnd"] = cliente.CliEnd;

            return View();
        }

        public ActionResult Produto()
        {
            Produto produto = new Produto()
            {
                ProdID = 1,
                prodNome = "Bom",
                prodValor = 149.99M,
                prodQtd = 100,
                ProdVencimento = DateTime.Parse("07/03/2019")
            };

            ViewBag.ProdID = produto.ProdID;
            ViewBag.ProdName = produto.prodNome;
            ViewBag.ProdValor = produto.prodValor;
            ViewBag.ProdQtd = produto.prodQtd;
            ViewBag.ProdVencimento = produto.ProdVencimento;

            return View();
        }

        public ActionResult Venda()
        {
            Venda venda = new Venda()
            {
                VendaID = 100,
                VendaData = DateTime.Parse("28/02/2019"),
                VendaTotal = 500
            };

            return View(venda);
        }

        public ActionResult Aluno()
        {

            return View();
        }
    }
}