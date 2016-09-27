namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnswerValeAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyCustomAnswerTable", "Value", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyCustomAnswerTable", "Value");
        }
    }
}
