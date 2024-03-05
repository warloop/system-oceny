namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attachments", "PoleAnkietyID", "dbo.PoleAnkieties");
            DropIndex("dbo.Attachments", new[] { "PoleAnkietyID" });
            AddColumn("dbo.Attachments", "PoleAnkiety_PoleAnkietyID", c => c.Int());
            AddColumn("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1", c => c.Int());
            CreateIndex("dbo.Attachments", "PoleAnkiety_PoleAnkietyID");
            CreateIndex("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1");
            AddForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1", "dbo.PoleAnkieties", "PoleAnkietyID");
            AddForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID", "dbo.PoleAnkieties", "PoleAnkietyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID", "dbo.PoleAnkieties");
            DropForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1", "dbo.PoleAnkieties");
            DropIndex("dbo.Attachments", new[] { "PoleAnkiety_PoleAnkietyID1" });
            DropIndex("dbo.Attachments", new[] { "PoleAnkiety_PoleAnkietyID" });
            DropColumn("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1");
            DropColumn("dbo.Attachments", "PoleAnkiety_PoleAnkietyID");
            CreateIndex("dbo.Attachments", "PoleAnkietyID");
            AddForeignKey("dbo.Attachments", "PoleAnkietyID", "dbo.PoleAnkieties", "PoleAnkietyID", cascadeDelete: true);
        }
    }
}
