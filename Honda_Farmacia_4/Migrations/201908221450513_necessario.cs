namespace Honda_Farmacia_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class necessario : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Farmaceuticoes", "LoginErrorMenssage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Farmaceuticoes", "LoginErrorMenssage", c => c.String());
        }
    }
}
