namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Senha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farmaceuticoes", "Senha", c => c.String());
            AddColumn("dbo.Logins", "LoginErrorMenssage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logins", "LoginErrorMenssage");
            DropColumn("dbo.Farmaceuticoes", "Senha");
        }
    }
}
