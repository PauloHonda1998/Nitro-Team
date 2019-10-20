using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class CadastrodeEmpresasColaboradoras
    {
        [Key]
        public int IdEmpresa { get; set; }

        public String Empresa { get; set; }

        public String CNPJ { get; set; }

        public DateTime Data { get; set; }

       
    }
}