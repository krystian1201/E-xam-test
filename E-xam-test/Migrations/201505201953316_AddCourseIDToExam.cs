namespace E_xam_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseIDToExam : DbMigration
    {
        public override void Up()
        {
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "CourseID", "dbo.Courses");
            DropIndex("dbo.Exams", new[] { "CourseID" });
            AlterColumn("dbo.Exams", "CourseID", c => c.Int());
            RenameColumn(table: "dbo.Exams", name: "CourseID", newName: "Course_ID");
            CreateIndex("dbo.Exams", "Course_ID");
            AddForeignKey("dbo.Exams", "Course_ID", "dbo.Courses", "ID");
        }
    }
}
