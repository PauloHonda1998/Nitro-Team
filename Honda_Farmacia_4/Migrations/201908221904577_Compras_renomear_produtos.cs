namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Compras_renomear_produtos : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Compras", name: "Produto_IdProdutos", newName: "Produtos_IdProdutos");
            RenameIndex(table: "dbo.Compras", name: "IX_Produto_IdProdutos", newName: "IX_Produtos_IdProdutos");
            AddColumn("dbo.Compras", "ProdutosId", c => c.Int(nullable: false));
            DropColumn("dbo.Compras", "ProdutoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Compras", "ProdutoId", c => c.Int(nullable: false));
            DropColumn("dbo.Compras", "ProdutosId");
            RenameIndex(table: "dbo.Compras", name: "IX_Produtos_IdProdutos", newName: "IX_Produto_IdProdutos");
            RenameColumn(table: "dbo.Compras", name: "Produtos_IdProdutos", newName: "Produto_IdProdutos");
        }
    }
}
