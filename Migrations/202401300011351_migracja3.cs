namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID", "dbo.PoleAnkieties");
            DropForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1", "dbo.PoleAnkieties");
            DropIndex("dbo.Attachments", new[] { "PoleAnkiety_PoleAnkietyID" });
            DropIndex("dbo.Attachments", new[] { "PoleAnkiety_PoleAnkietyID1" });
            DropTable("dbo.Attachments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Attachments",
                c => new
                    {
                        AttachmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FileType = c.String(),
                        FilePath = c.String(),
                        PoleAnkietyID = c.Int(nullable: false),
                        PoleAnkiety_PoleAnkietyID = c.Int(),
                        PoleAnkiety_PoleAnkietyID1 = c.Int(),
                    })
                .PrimaryKey(t => t.AttachmentID);
            
            CreateIndex("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1");
            CreateIndex("dbo.Attachments", "PoleAnkiety_PoleAnkietyID");
            AddForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1", "dbo.PoleAnkieties", "PoleAnkietyID");
            AddForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID", "dbo.PoleAnkieties", "PoleAnkietyID");
        }
    }
}
