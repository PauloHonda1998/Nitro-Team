namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empresa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "Quantidade", c => c.Int(nullable: false));
            AlterColumn("dbo.Produtos", "Valor", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Valor", c => c.Int(nullable: false));
            AlterColumn("dbo.Produtos", "Quantidade", c => c.String(nullable: false));
        }
    }
}
