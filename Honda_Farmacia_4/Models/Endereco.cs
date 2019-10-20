using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Endereco()
        {
            
            this.Pessoa = new HashSet<Pessoa>();
        }
        [Key]    
        public int Codigo_Endereco { get; set; }
        public Nullable<int> Codigo_Cidade { get; set; }
        [Display(Name = "Endereco")]
        public string Endereco1 { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
    
        public string Cidade { get; set; }
        public String UF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
 
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pessoa> Pessoa { get; set; }
    }
}

