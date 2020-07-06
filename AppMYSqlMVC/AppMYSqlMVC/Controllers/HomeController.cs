using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using AppMYSqlMVC.Models;

namespace AppMYSqlMVC.Controllers
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

        public ActionResult ListaCliente()
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost; User ID=noturno; database=dbECOMMERCE; password=12345678");

            MySqlCommand comando = new MySqlCommand("SELECT * FROM tbCliente", conexao);

            conexao.Open();

            MySqlDataReader registros = comando.ExecuteReader();

            var cliente = new List<clientes>();

            while (registros.Read())
            {
                var cli = new clientes()
                {
                    ClienteId = int.Parse(registros["ClienteId"].ToString()),
                    Nome = registros["Nome"].ToString(),
                    DataNasc = DateTime.Parse(registros["DataNasc"].ToString()),
                    Telefone = decimal.Parse(registros["Telefone"].ToString())

                };
                cliente.Add(cli);
            }

            return View(cliente);
        }
    }
}