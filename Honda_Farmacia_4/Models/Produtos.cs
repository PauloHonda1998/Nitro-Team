using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Produtos
    {

        [Key]
        public int IdProdutos { get; set; }
        [Display (Name = "Código")]
        [Required(ErrorMessage = "Seu Código é Obrigatório")]
        public string Codigo { get; set; }

        [Display(Name = "Código de Barras")]
        [Required(ErrorMessage = "Seu Código de Barras é Obrigatório")]
        public string Codigo_de_Barra { get; set; }

        [Required(ErrorMessage = "Seu Nome é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Seu Data é Obrigatório")]
        public string Data { get; set; }

        [Required(ErrorMessage = "Seu Descrição é Obrigatório")]
        public string Descrição { get; set; }

        [Required(ErrorMessage = "Seu Quantidade é Obrigatório")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Seu Valor é Obrigatório")]
        public float Valor { get; set; }



    }
}