using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NovoTerceiraApp.Models;

namespace NovoTerceiraApp.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            Produto produto = new Produto()
            {
                Id = 1,
                Nome = "Vencido",
                Valor = 200.66M,
                Qtd = 50
        };

            return View(produto);
        }
    }
}