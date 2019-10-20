namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Senha1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farmaceuticoes", "LoginErrorMenssage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Farmaceuticoes", "LoginErrorMenssage");
        }
    }
}
