namespace OOP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja1 : DbMigration
    {
        public override void Up()
        {

        }
        public override void Down()
        {
            DropForeignKey("dbo.Schemats", "DzialID", "dbo.Dzials");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.StronaAnkieties", "AnkietaID", "dbo.Ankietas");
            DropForeignKey("dbo.Pracowniks", "Przelozony_PracownikID", "dbo.Pracowniks");
            DropForeignKey("dbo.PracaDyplomowas", "PracownikID", "dbo.Pracowniks");
            DropForeignKey("dbo.Osiagniecies", "PracownikID", "dbo.Pracowniks");
            DropForeignKey("dbo.PoleAnkieties", "StronaAnkietyID", "dbo.StronaAnkieties");
            DropForeignKey("dbo.Comments", "CommentID", "dbo.PoleAnkieties");
            DropForeignKey("dbo.Comments", "ApplicationUserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID1", "dbo.PoleAnkieties");
            DropForeignKey("dbo.Attachments", "PoleAnkiety_PoleAnkietyID", "dbo.PoleAnkieties");
            DropForeignKey("dbo.StronaAnkieties", "DzialID", "dbo.Dzials");
            DropForeignKey("dbo.Osiagniecies", "DzialID", "dbo.Dzials");
            DropForeignKey("dbo.Ocenas", "PracownikID", "dbo.Pracowniks");
            DropForeignKey("dbo.Pracowniks", "Komisja_KomisjaID", "dbo.Komisjas");
            DropForeignKey("dbo.Ocenas", "KomisjaID", "dbo.Komisjas");
            DropForeignKey("dbo.Ocenas", "DzialID", "dbo.Dzials");
            DropForeignKey("dbo.Dzials", "ApplicationUserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Pracowniks", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Ankietas", "PracownikID", "dbo.Pracowniks");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Adres_AdresID", "dbo.Adres");
            DropIndex("dbo.Schemats", new[] { "DzialID" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.PracaDyplomowas", new[] { "PracownikID" });
            DropIndex("dbo.Comments", new[] { "ApplicationUserID" });
            DropIndex("dbo.Comments", new[] { "CommentID" });
            DropIndex("dbo.Attachments", new[] { "PoleAnkiety_PoleAnkietyID1" });
            DropIndex("dbo.Attachments", new[] { "PoleAnkiety_PoleAnkietyID" });
            DropIndex("dbo.PoleAnkieties", new[] { "StronaAnkietyID" });
            DropIndex("dbo.StronaAnkieties", new[] { "AnkietaID" });
            DropIndex("dbo.StronaAnkieties", new[] { "DzialID" });
            DropIndex("dbo.Ocenas", new[] { "PracownikID" });
            DropIndex("dbo.Ocenas", new[] { "KomisjaID" });
            DropIndex("dbo.Ocenas", new[] { "DzialID" });
            DropIndex("dbo.Dzials", new[] { "ApplicationUserID" });
            DropIndex("dbo.Osiagniecies", new[] { "PracownikID" });
            DropIndex("dbo.Osiagniecies", new[] { "DzialID" });
            DropIndex("dbo.Pracowniks", new[] { "Przelozony_PracownikID" });
            DropIndex("dbo.Pracowniks", new[] { "Komisja_KomisjaID" });
            DropIndex("dbo.Pracowniks", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Ankietas", new[] { "PracownikID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Adres_AdresID" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropTable("dbo.Schemats");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PracaDyplomowas");
            DropTable("dbo.Comments");
            DropTable("dbo.Attachments");
            DropTable("dbo.PoleAnkieties");
            DropTable("dbo.StronaAnkieties");
            DropTable("dbo.Komisjas");
            DropTable("dbo.Ocenas");
            DropTable("dbo.Dzials");
            DropTable("dbo.Osiagniecies");
            DropTable("dbo.Pracowniks");
            DropTable("dbo.Ankietas");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Adres");
        }
    }
}
