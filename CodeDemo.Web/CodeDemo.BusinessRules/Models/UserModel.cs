using CodeDemo.Data.Entities;

namespace CodeDemo.BusinessRules.Models
{
    public class UserModel
    {
        public UserModel()
        {
            People=new People();
            User=new User();
        }

        public People People { get; set; }
        public User User { get; set; }
    }
}
