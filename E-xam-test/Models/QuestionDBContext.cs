

using System.Data.Entity;


namespace E_xam_test.Models
{
    public class QuestionDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public QuestionDBContext() : base("name=QuestionDBContext")
        {
        }

        public System.Data.Entity.DbSet<E_xam_test.Models.Question> Questions { get; set; }
    
    }
}
