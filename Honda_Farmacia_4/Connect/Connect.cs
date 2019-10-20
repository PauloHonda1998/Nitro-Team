
using System.Data.Entity;

namespace Models
{
    public class Connect : DbContext
    {

        public Connect() : base("Connect")
        {

        }

        public DbSet<Farmaceutico> Farmaceutico { get; set; }
        public DbSet<Produtos> Produto { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<CadastrodeEmpresasColaboradoras> CadastrodeEmpresasColaboradoras { get; set; }
        public System.Data.Entity.DbSet<Models.Compra> Compras { get; set; }
    }
}