namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio_Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Farmaceuticoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CRF = c.String(),
                        Nome = c.String(),
                        Cpf = c.String(nullable: false),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        IdProdutos = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Codigo_de_Barra = c.String(),
                        Nome = c.String(),
                        Data = c.String(),
                        Descrição = c.String(),
                        Quantidade = c.String(),
                        Valor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProdutos);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
            DropTable("dbo.Farmaceuticoes");
        }
    }
}
