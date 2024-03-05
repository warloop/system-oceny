namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PoleAnkieties", "AttachmentID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PoleAnkieties", "AttachmentID", c => c.Int(nullable: false));
        }
    }
}
