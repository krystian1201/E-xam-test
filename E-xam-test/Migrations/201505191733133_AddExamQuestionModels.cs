namespace E_xam_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExamQuestionModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time = c.Time(nullable: false, precision: 7),
                        Text = c.String(nullable: false),
                        Points = c.Int(nullable: false),
                        Exam_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exams", t => t.Exam_ID)
                .Index(t => t.Exam_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Exam_ID", "dbo.Exams");
            DropIndex("dbo.Questions", new[] { "Exam_ID" });
            DropTable("dbo.Questions");
            DropTable("dbo.Exams");
        }
    }
}
