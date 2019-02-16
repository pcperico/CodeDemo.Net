using System.ComponentModel;
using System.Data.Entity;


namespace CodeDemo.Data
{
    public class DBContexCodeDemo : DbContext
    {
        public DBContexCodeDemo():base("CodeDemoConnectionString")
        {
        
        }

        
    }
}
