namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Compras", "Codigo_de_Barra_IdProdutos", "dbo.Produtos");
            DropIndex("dbo.Compras", new[] { "Codigo_de_Barra_IdProdutos" });
            AddColumn("dbo.Compras", "Codigo_de_Barra", c => c.String());
            DropColumn("dbo.Compras", "Codigo_de_Barra_IdProdutos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Compras", "Codigo_de_Barra_IdProdutos", c => c.Int());
            DropColumn("dbo.Compras", "Codigo_de_Barra");
            CreateIndex("dbo.Compras", "Codigo_de_Barra_IdProdutos");
            AddForeignKey("dbo.Compras", "Codigo_de_Barra_IdProdutos", "dbo.Produtos", "IdProdutos");
        }
    }
}
