using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaLojaBoa.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        public DateTime VendaData { get; set; }
        public decimal VendaTotal { get; set; }
    }
}