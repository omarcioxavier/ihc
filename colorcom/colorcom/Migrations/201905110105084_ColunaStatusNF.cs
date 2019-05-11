namespace colorcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColunaStatusNF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.entradaNF", "en_status", c => c.Boolean(nullable: false));
            AddColumn("dbo.saidaNF", "sn_status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.saidaNF", "sn_status");
            DropColumn("dbo.entradaNF", "en_status");
        }
    }
}
