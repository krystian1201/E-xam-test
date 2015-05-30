namespace E_xam_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseToExam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Exams", "Course_ID", c => c.Int());
            CreateIndex("dbo.Exams", "Course_ID");
            AddForeignKey("dbo.Exams", "Course_ID", "dbo.Courses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "Course_ID", "dbo.Courses");
            DropIndex("dbo.Exams", new[] { "Course_ID" });
            DropColumn("dbo.Exams", "Course_ID");
            DropTable("dbo.Courses");
        }
    }
}
