namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attachments", "PoleAnkietyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Attachments", "PoleAnkietyID", c => c.Int());
        }
    }
}
