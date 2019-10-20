using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Seu Nome é Obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Seu CPF é Obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Seu CEP é Obrigatório")]
        public string CEP { get; set; }





    }
}