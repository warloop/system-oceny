namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja4 : DbMigration
    {
        public override void Up()
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
                    })
                .PrimaryKey(t => t.AttachmentID)
                .ForeignKey("dbo.PoleAnkieties", t => t.PoleAnkietyID, cascadeDelete: true)
                .Index(t => t.PoleAnkietyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attachments", "PoleAnkietyID", "dbo.PoleAnkieties");
            DropIndex("dbo.Attachments", new[] { "PoleAnkietyID" });
            DropTable("dbo.Attachments");
        }
    }
}
