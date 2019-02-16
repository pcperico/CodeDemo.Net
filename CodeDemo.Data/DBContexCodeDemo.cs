using AutoShopSystemManagement.Data.Entities;
using System.ComponentModel;
using System.Data.Entity;


namespace CodeDemo.Data
{
    public class DBContexCodeDemo : DbContext
    {
        public DBContexCodeDemo():base("CodeDemoConnectionString")
        {
        
        }

        public DbSet<People>People { get; set; }
    }
}
