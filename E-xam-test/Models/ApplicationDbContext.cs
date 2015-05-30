
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

using E_xam_test.Migrations;


namespace E_xam_test.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            //it is needed for automatic migrations to work
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>()); 
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
    
}
