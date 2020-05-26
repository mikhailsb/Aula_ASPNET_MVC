using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace QuintaApp.Models
{
    public class Usuario
    {
        [Display(Name ="ID do Usuário: ")]
        [Range(1,200, ErrorMessage ="O Id deve estar entre 1 e 255.")]
        public ushort UsuId { get; set; }

        [Display(Name = "Nome do Usuaário: ")]
        [Required(ErrorMessage = "Nome obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Observação: ")]
        [StringLength(50, MinimumLength =5, ErrorMessage ="Informar entre 5 a 50 caracteres")]
        public string Obs { get; set; }

        [Display(Name ="Data de Nascimento: ")]
        [Required(ErrorMessage ="Informe a data de nascimento!")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Nasc { get; set; }

        [Display(Name ="E-mail do Usuário:")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\-][a-zA-Z])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Display(Name ="Login do Usuário:")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage ="Somente letras, no mínimo 5 e máximo 15.")]
        [Required(ErrorMessage ="Campo Obrigarório")]
        [Remote("ValidaLogin","Usuario", ErrorMessage = "Login já existente")]
        public string Login { get; set; }

        [Display(Name = "Senha do Usuário: ")]
        [Required(ErrorMessage = "Senha obrigarório")]
        public string Senha { get; set; }

        [Display(Name ="Conforme esta porra: ")]
        [Compare("Senha", ErrorMessage = "Senhas incompativeis")]
        public string ConfirmaSenha { get; set; }
    }
}