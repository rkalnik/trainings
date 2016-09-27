namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyCustomAnswerTable",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        AnswerNewColumnName = c.String(nullable: false, maxLength: 200),
                        IsCorrect = c.Boolean(nullable: false),
                        QuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Questionsblabla", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questionsblabla",
                c => new
                    {
                        QuestionNumber = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.QuestionNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyCustomAnswerTable", "QuestionId", "dbo.Questionsblabla");
            DropIndex("dbo.MyCustomAnswerTable", new[] { "QuestionId" });
            DropTable("dbo.Questionsblabla");
            DropTable("dbo.MyCustomAnswerTable");
        }
    }
}
