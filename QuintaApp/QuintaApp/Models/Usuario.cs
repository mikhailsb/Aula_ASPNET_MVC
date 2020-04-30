using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuintaApp.Models
{
    public class Usuario
    {
        public short UsuID { get; set; }
        public string Nome { get; set; }
        public string Obs { get; set; }
        public DateTime Nasc { get; set; }
        public string Email { get; set; }
        public string Lgoin { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}