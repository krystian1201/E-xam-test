
using System.Data.Entity;
using E_xam_test.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;

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
    }
    
}
