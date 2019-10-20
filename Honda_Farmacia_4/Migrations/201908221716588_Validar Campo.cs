namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidarCampo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Farmaceuticoes", "CNPJ", c => c.String(nullable: false));
            AlterColumn("dbo.Farmaceuticoes", "CRF", c => c.String(nullable: false));
            AlterColumn("dbo.Farmaceuticoes", "Senha", c => c.String(nullable: false));
            AlterColumn("dbo.Farmaceuticoes", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Farmaceuticoes", "CEP", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Farmaceuticoes", "CEP", c => c.String());
            AlterColumn("dbo.Farmaceuticoes", "Nome", c => c.String());
            AlterColumn("dbo.Farmaceuticoes", "Senha", c => c.String());
            AlterColumn("dbo.Farmaceuticoes", "CRF", c => c.String());
            AlterColumn("dbo.Farmaceuticoes", "CNPJ", c => c.String());
        }
    }
}
