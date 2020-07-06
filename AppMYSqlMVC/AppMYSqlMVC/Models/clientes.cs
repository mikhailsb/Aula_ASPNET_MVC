using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMYSqlMVC.Models
{
    public class clientes
    {
        public int ClienteId { get; set; }

        [StringLength(50, ErrorMessage = "Até 50 caracteres")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime DataNasc { get; set; }
        public Decimal Telefone { get; set; }
    }
}