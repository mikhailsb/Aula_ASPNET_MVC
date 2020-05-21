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

        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="Somente letras, no mínimo 5 e máximo 15.")]
        [Required(ErrorMessage ="Campo Obrigarório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha obrigarório")]
        public string Senha { get; set; }
        [Compare("Senha", ErrorMessage = "Senhas incompativeis")]
        public string ConfirmaSenha { get; set; }
    }
}