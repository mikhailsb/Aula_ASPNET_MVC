using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovoTerceiraApp.Models
{
    public class Fornecedor
    {
        public int fornecID { get; set; }
        public string endereco { get; set; }
        public string nome { get; set; }
        public int tel { get; set; }
    }
}