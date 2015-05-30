namespace E_xam_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDuration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Exams", "Duration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "Duration", c => c.Time(nullable: false, precision: 7));
        }
    }
}
