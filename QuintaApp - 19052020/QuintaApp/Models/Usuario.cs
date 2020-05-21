using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuintaApp.Models
{
    public class Usuario
    {
        [Range(1,255, ErrorMessage ="O Id deve estar entre 1 e 255.")]
        public ushort UsuId { get; set; }

        [Required(ErrorMessage = "Nome obrigatório!")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength =5, ErrorMessage ="Informar entre 5 a 50 caracteres")]
        public string Obs { get; set; }

        [Required(ErrorMessage ="Informe a data de nascimento!")]
        [DisplayFormat(DataFormatString ="0:dd/MM/yyyy", ApplyFormatInEditMode =true)]
        public DateTime Nasc { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
    }
}