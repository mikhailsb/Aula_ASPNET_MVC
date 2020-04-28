using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaLojaBoa.Models
{
    public class Produto
    {
        public int ProdID { get; set; }
        public string prodNome { get; set; }

        public decimal prodValor { get; set; }

        public int prodQtd { get; set; }

        public DateTime ProdVencimento { get; set; }

    }
}