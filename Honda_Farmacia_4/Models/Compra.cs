using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Farmaceutico CRF ")]
        public int FarmaceuticoId { get; set; }

        
        public Farmaceutico Farmaceutico { get; set; }

        [Display(Name = "Produto")]
        public int ProdutosId { get; set; }
        public Produtos Produtos { get; set; }
       
        public string Codigo_de_Barra { get; set; }
        public DateTime DataCompra { get; set; }

        public int Quantidade { get; set; }
    }
}