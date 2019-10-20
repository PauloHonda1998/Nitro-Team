namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Compras : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FarmaceuticoId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        DataCompra = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Produto_IdProdutos = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farmaceuticoes", t => t.FarmaceuticoId, cascadeDelete: true)
                .ForeignKey("dbo.Produtos", t => t.Produto_IdProdutos)
                .Index(t => t.FarmaceuticoId)
                .Index(t => t.Produto_IdProdutos);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Produto_IdProdutos", "dbo.Produtos");
            DropForeignKey("dbo.Compras", "FarmaceuticoId", "dbo.Farmaceuticoes");
            DropIndex("dbo.Compras", new[] { "Produto_IdProdutos" });
            DropIndex("dbo.Compras", new[] { "FarmaceuticoId" });
            DropTable("dbo.Compras");
        }
    }
}
