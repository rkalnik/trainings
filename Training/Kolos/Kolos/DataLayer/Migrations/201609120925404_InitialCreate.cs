namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UltimateBlogs",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Rating = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogId)
                .ForeignKey("dbo.UltimateUsers", t => t.AdminId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.UltimateUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                        BrithDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        AdressId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UltimateUserAdresses", t => t.AdressId)
                .Index(t => t.AdressId);
            
            CreateTable(
                "dbo.UltimateUserAdresses",
                c => new
                    {
                        UserAddressId = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Zip = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserAddressId);
            
            CreateTable(
                "dbo.UltimatePosts",
                c => new
                    {
                        PostNumber = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        Title = c.String(maxLength: 200),
                        Content = c.String(maxLength: 1000),
                        CreationDate = c.DateTime(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostNumber)
                .ForeignKey("dbo.UltimateUsers", t => t.AuthorId)
                .ForeignKey("dbo.UltimateBlogs", t => t.BlogId)
                .Index(t => t.BlogId)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UltimatePosts", "BlogId", "dbo.UltimateBlogs");
            DropForeignKey("dbo.UltimatePosts", "AuthorId", "dbo.UltimateUsers");
            DropForeignKey("dbo.UltimateBlogs", "AdminId", "dbo.UltimateUsers");
            DropForeignKey("dbo.UltimateUsers", "AdressId", "dbo.UltimateUserAdresses");
            DropIndex("dbo.UltimatePosts", new[] { "AuthorId" });
            DropIndex("dbo.UltimatePosts", new[] { "BlogId" });
            DropIndex("dbo.UltimateUsers", new[] { "AdressId" });
            DropIndex("dbo.UltimateBlogs", new[] { "AdminId" });
            DropTable("dbo.UltimatePosts");
            DropTable("dbo.UltimateUserAdresses");
            DropTable("dbo.UltimateUsers");
            DropTable("dbo.UltimateBlogs");
        }
    }
}
