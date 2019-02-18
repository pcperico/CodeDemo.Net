using CodeDemo.Data.Entities;
using CodeDemo.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.Data.Repositories.Impl
{
    public class PeopleRepository:Repository<People>, IPeopleRepository
    {
    }
}
