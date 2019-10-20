
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Login
    {
        [Key]
        public string Id { get; set; }
        
        public string Usuario { get; set; }
        
        
        public string Senha { get; set; }

        public string LoginErrorMenssage { get; set; }
    }
}