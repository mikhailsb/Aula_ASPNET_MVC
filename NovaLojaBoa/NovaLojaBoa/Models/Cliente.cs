using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaLojaBoa.Models
{
    public class Cliente
    {
        public int CliID { get; set; }
        public string CliNome { get; set; }
        public string  CliEnd { get; set; }
        public DateTime CliNasc { get; set; }

    }
}