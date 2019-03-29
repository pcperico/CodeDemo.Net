using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeDemo.Data.Entities;
using CodeDemo.Data.Repositories.Interfaces;

namespace CodeDemo.Data.Repositories.Impl
{
    public class UserRepository:Repository<User>,IUserRepository
    {
    }
}
