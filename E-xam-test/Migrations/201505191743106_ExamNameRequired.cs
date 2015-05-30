
namespace E_xam_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExamNameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exams", "Name", c => c.String());
        }
    }
}
