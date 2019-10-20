using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Farmaceutico : Pessoa 
    {
        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Seu CNPJ é Obrigatório")]
        public string CNPJ { get; set; }

        [Display(Name = "CRF")]
        [Required(ErrorMessage = "Seu CRF é Obrigatório")]
        public string CRF { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Seu Senha é Obrigatório")]
        public string Senha { get; set; }

        public Endereco Endereco { get; set; }



    }
}