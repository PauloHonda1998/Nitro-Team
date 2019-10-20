namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compras", "Codigo_de_Barra_IdProdutos", c => c.Int());
            CreateIndex("dbo.Compras", "Codigo_de_Barra_IdProdutos");
            AddForeignKey("dbo.Compras", "Codigo_de_Barra_IdProdutos", "dbo.Produtos", "IdProdutos");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Codigo_de_Barra_IdProdutos", "dbo.Produtos");
            DropIndex("dbo.Compras", new[] { "Codigo_de_Barra_IdProdutos" });
            DropColumn("dbo.Compras", "Codigo_de_Barra_IdProdutos");
        }
    }
}
