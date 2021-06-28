namespace LyVanTrieu_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(nullable: false, maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 255),
                        Datetime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerId, cascadeDelete: true)
                .Index(t => t.LecturerId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coures", "LecturerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Coures", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Coures", new[] { "CategoryId" });
            DropIndex("dbo.Coures", new[] { "LecturerId" });
            DropTable("dbo.Coures");
            DropTable("dbo.Categories");
        }
    }
}
