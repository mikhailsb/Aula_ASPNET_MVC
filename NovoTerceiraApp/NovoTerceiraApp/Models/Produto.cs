using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovoTerceiraApp.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public ushort Qtd { get; set; }

    }
}