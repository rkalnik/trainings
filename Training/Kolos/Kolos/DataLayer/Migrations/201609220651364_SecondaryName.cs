namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondaryName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UltimateBlogs", "SecondaryName", c => c.String());
            AddColumn("dbo.UltimateBlogs", "Subtitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UltimateBlogs", "Subtitle");
            DropColumn("dbo.UltimateBlogs", "SecondaryName");
        }
    }
}
