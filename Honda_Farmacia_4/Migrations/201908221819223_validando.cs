namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validando : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Produtos", "Codigo_de_Barra", c => c.String(nullable: false));
            AlterColumn("dbo.Produtos", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Produtos", "Data", c => c.String(nullable: false));
            AlterColumn("dbo.Produtos", "Descrição", c => c.String(nullable: false));
            AlterColumn("dbo.Produtos", "Quantidade", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Quantidade", c => c.String());
            AlterColumn("dbo.Produtos", "Descrição", c => c.String());
            AlterColumn("dbo.Produtos", "Data", c => c.String());
            AlterColumn("dbo.Produtos", "Nome", c => c.String());
            AlterColumn("dbo.Produtos", "Codigo_de_Barra", c => c.String());
            AlterColumn("dbo.Produtos", "Codigo", c => c.String());
        }
    }
}
