namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PoleAnkieties", "AttachmentID", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PoleAnkieties", "AttachmentID");
        }
    }
}
