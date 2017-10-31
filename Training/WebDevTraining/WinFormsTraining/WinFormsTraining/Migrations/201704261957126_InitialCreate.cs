namespace WinFormsTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(defaultValue:"John"),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        BookAuthor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.BookAuthor_Id)
                .Index(t => t.BookAuthor_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PagesCount = c.Int(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        BookAuthor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.BookAuthor_Id)
                .Index(t => t.BookAuthor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookAuthor_Id", "dbo.Authors");
            DropForeignKey("dbo.Authors", "BookAuthor_Id", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "BookAuthor_Id" });
            DropIndex("dbo.Authors", new[] { "BookAuthor_Id" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
