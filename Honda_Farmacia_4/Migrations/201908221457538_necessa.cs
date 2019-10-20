namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class necessa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farmaceuticoes", "CNPJ", c => c.String());
            AddColumn("dbo.Farmaceuticoes", "CEP", c => c.String());
            DropColumn("dbo.Farmaceuticoes", "Endereco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Farmaceuticoes", "Endereco", c => c.String());
            DropColumn("dbo.Farmaceuticoes", "CEP");
            DropColumn("dbo.Farmaceuticoes", "CNPJ");
        }
    }
}
