using CodeDemo.Data.Entities;
using System.Data.Entity;


namespace CodeDemo.Data
{
    public class DBContexCodeDemo : DbContext
    {
        public DBContexCodeDemo():base("CodeDemoConnectionString")
        {
        
        }

        public DbSet<People>People { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
