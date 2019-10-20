namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CadastroDeEmpresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadastrodeEmpresasColaboradoras",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false, identity: true),
                        Empresa = c.String(),
                        CNPJ = c.String(),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdEmpresa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CadastrodeEmpresasColaboradoras");
        }
    }
}
