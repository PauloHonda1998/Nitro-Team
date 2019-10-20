namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
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
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FarmaceuticoId = c.Int(nullable: false),
                        ProdutosId = c.Int(nullable: false),
                        DataCompra = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Produtos_IdProdutos = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.FarmaceuticoId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.Produtos_IdProdutos)
                .Index(t => t.FarmaceuticoId)
                .Index(t => t.Produtos_IdProdutos);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(nullable: false),
                        CEP = c.String(nullable: false),
                        CNPJ = c.String(),
                        CRF = c.String(),
                        Senha = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Endereco_Codigo_Endereco = c.Int(),
                        Endereco_Codigo_Endereco1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_Codigo_Endereco)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_Codigo_Endereco1)
                .Index(t => t.Endereco_Codigo_Endereco)
                .Index(t => t.Endereco_Codigo_Endereco1);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Codigo_Endereco = c.Int(nullable: false, identity: true),
                        Codigo_Cidade = c.Int(),
                        Endereco1 = c.String(),
                        Numero = c.Int(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        UF = c.String(),
                    })
                .PrimaryKey(t => t.Codigo_Endereco);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        IdProdutos = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false),
                        Codigo_de_Barra = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Data = c.String(nullable: false),
                        Descrição = c.String(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IdProdutos);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Usuario = c.String(),
                        Senha = c.String(),
                        LoginErrorMenssage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Produtos_IdProdutos", "dbo.Produtos");
            DropForeignKey("dbo.Compras", "FarmaceuticoId", "dbo.Pessoas");
            DropForeignKey("dbo.Pessoas", "Endereco_Codigo_Endereco1", "dbo.Enderecoes");
            DropForeignKey("dbo.Pessoas", "Endereco_Codigo_Endereco", "dbo.Enderecoes");
            DropIndex("dbo.Pessoas", new[] { "Endereco_Codigo_Endereco1" });
            DropIndex("dbo.Pessoas", new[] { "Endereco_Codigo_Endereco" });
            DropIndex("dbo.Compras", new[] { "Produtos_IdProdutos" });
            DropIndex("dbo.Compras", new[] { "FarmaceuticoId" });
            DropTable("dbo.Logins");
            DropTable("dbo.Produtos");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Compras");
            DropTable("dbo.CadastrodeEmpresasColaboradoras");
        }
    }
}
